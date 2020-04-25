<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot-password.aspx.cs" Inherits="truevalueauction.Pages.forgot_username_or_password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Theme/bootstrap.min.css" rel="stylesheet" />
    <link href="../Theme/login2.css" rel="stylesheet" />
    <title>Forgot Password</title>
</head>
<body>
    <form style="height: 300px" runat="server">
        <div class="container text-center main-container">

            <div class="text-center">
                <div class="text-center" style="font-weight: bold; font-size: 30px">
                    Please enter your email address
                </div>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control txtBox"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-default" />
            </div>
        </div>
    </form>
    <script src="../Scripts/login.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../Theme/bootstrap.min.js"></script>
</body>
</html>
