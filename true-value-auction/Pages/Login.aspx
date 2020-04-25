<%@ Page Language="C#" CodeBehind="Login.aspx.cs" Inherits="truevalueauction.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="../Theme/bootstrap.min.css" rel="stylesheet" />
    <link href="../Theme/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="nav text-center" style="background-color: #345eeb; color: white">
            <h1>True Value Auctions</h1>
        </div>
        <div id="container1" class="container text-center main-container" style="padding: 50px; background-color: #cecece">
            <asp:Literal ID="alertBody" runat="server"></asp:Literal>
            <div id="form-group1" class="form-group">
                <label class="h3">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control txtBox" TextMode="Email" Width="50%"></asp:TextBox>
            </div>
            <div class="form-group">
                <label class="h3">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control txtBox" TextMode="Password" Width="50%"></asp:TextBox>
            </div>
            <br />
            <div class="text-center">
                <button id="btnLogin" type="button" class="btn btn-default" data-target="#myModal" style="width: 100px">
                    Login
                </button>
                <span style="margin-left: 10px">
                    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal" style="width: 100px">
                        Register
                    </button>
                </span>
            </div>
            <div style="text-align: center; margin-top: 10px">
                <asp:HyperLink ID="linkForgottenLogin" runat="server" CssClass="forgotLogin" NavigateUrl="~/Pages/forgot-username-or-password.aspx">Fogot Username/Password</asp:HyperLink>
            </div>
        </div>

        <!-- Modal -->
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header btn-primary">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel">Register</h4>
                    </div>
                    <div class="modal-body">
                        <asp:Literal ID="alertModal" runat="server"></asp:Literal>
                        <label id="fn" class="h3">First Name</label>
                        <asp:TextBox ID="txtRegisterFirstName" runat="server" CssClass="form-control txtBox-Register"></asp:TextBox>
                        <label class="h3">Email</label>
                        <asp:TextBox ID="txtRegisterEmail" runat="server" CssClass="form-control txtBox-Register" TextMode="Email"></asp:TextBox>
                        <label class="h3">Password</label>
                        <asp:TextBox ID="txtRegisterPassword" runat="server" CssClass="form-control txtBox-Register" TextMode="Password"></asp:TextBox>
                        <label class="h3">Confirm Password</label>
                        <asp:TextBox ID="txtRegisterConfirmPassword" runat="server" CssClass="form-control txtBox-Register" TextMode="Password"></asp:TextBox>
                        <span id="helpBlock" class="help-block">Password must contain: 
                            <br />
                            - At least two lowercase letters
                            <br />
                            - At least two UPPERCASE letters
                            <br />
                            - At least two numbers [0-9]
                            <br />
                            - At Least two special characters [!@#$%^&*]
                            <br />
                            - At least 9 characters
                        </span>
                    </div>
                    <div class="modal-footer">
                        <button id="btnRegister" type="button" class="btn btn-primary">Register</button>
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="../Scripts/login.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../Theme/bootstrap.min.js"></script>
</body>
</html>
