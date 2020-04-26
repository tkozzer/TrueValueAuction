<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot-password.aspx.cs" Inherits="truevalueauction.Pages.forgot_username_or_password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Theme/bootstrap.min.css" rel="stylesheet" />
    <link href="../Theme/login.css" rel="stylesheet" />
    <title>Forgot Password</title>
</head>
<body>
    <form style="height: 300px" runat="server">
        <div id="container1" class="container text-center main-container">
            <asp:Literal ID="alertForgot" runat="server"></asp:Literal>
            <div id="div1" class="text-center">
                <div class="text-center" style="font-weight: bold; font-size: 30px">
                    Please enter your email address
                </div>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtForgotEmail" runat="server" CssClass="form-control txtBox" TextMode="Email"></asp:TextBox>
            </div>
            <div class="text-center">
                <input id="btnSubmit" type="button" value="Submit" class="btn btn-default" style="width: 150px"/>
            </div>
            <div class="text-center" style="margin-top: 10px">
                <asp:HyperLink ID="linkToLogin" runat="server" CssClass="forgotLogin" NavigateUrl="~/Pages/login.aspx">Go Back to Login</asp:HyperLink>
            </div>
        </div>
    </form>
    <script src="../Scripts/forgot-password.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../Theme/bootstrap.min.js"></script>
</body>
</html>
