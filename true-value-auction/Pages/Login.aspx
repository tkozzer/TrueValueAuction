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
        <div class="container text-center" style="padding: 50px; background-color: #cecece">
            <asp:Literal ID="alertBody" runat="server"></asp:Literal>
            <div class="form-group">
                <label class="h3">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control txtBox" TextMode="Email" Width="50%"></asp:TextBox>
            </div>
            <div class="form-group">
                <label class="h3">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control txtBox" TextMode="Password" Width="50%"></asp:TextBox>
            </div>
            <br />
            <div class="text-center">
                <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-default" Text="Login" Width="100px" OnClick="btnLogin_Click" />
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
                        </span>
                    </div>
                    <div class="modal-footer">
                        <button id="btn" type="button" class="btn btn-primary">Register</button>
                        <asp:Button ID="btnRegister" CssClass="btn btn-primary" runat="server" Text="Sign Up!" OnClick="btnRegister_Click" />
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script>
        var alert = document.getElementById('alert');
        console.log(alert);
        if (document.getElementById('alert') !== null) {
            console.log("alertLiteral not empty");
            setTimeout(() => document.querySelector('.alert').remove(), 5000)
        };

        var firstName = document.getElementById('txtRegisterFirstName');
        var email = document.getElementById('txtRegisterEmail');
        var password = document.getElementById('txtRegisterPassword');
        var confirmPassword = document.getElementById('txtRegisterConfirmPassword');

        document.getElementById('btn').addEventListener("click", () => {
            if (firstName.value === "" || email.value === "" || password.value === "" || confirmPassword.value === "") {
                showAlert('Please make sure all fields are filled in');
            } else if (password.value != confirmPassword.value) {
                showAlert("Please make sure your passwords match");
            } else {
                __doPostBack('btn', 'Click');
            }
        })


        function showAlert(message) {
            const div = document.createElement('div');
            div.className = 'alert alert-danger';
            div.id = 'alertModal';
            div.appendChild(document.createTextNode(message));
            const modalBody = document.querySelector('.modal-body');
            const h3 = document.querySelector('#fn');
            modalBody.insertBefore(div, h3);

            //Vanish in 5 seconds
            setTimeout(() => document.querySelector('#alertModal').remove(), 5000);
        }
    </script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../Theme/bootstrap.min.js"></script>
</body>
</html>
