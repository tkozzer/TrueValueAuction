<%@ Page Language="C#" Inherits="truevalueauction.Pages.Home" CodeBehind="~/Pages/Home.aspx.cs" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <link href="../Theme/bootstrap.min.css" rel="stylesheet" />
    <link href="../Theme/home.css" rel="stylesheet" />
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-static-top" style="background-color:#e0e0e0">
            <div class="row" style="margin-top: 5px; margin-right: 10px">
                <div class="col-sm-6" style="background-color: aliceblue">
                    <h1>True Value Auction</h1>
                </div>
                <div class="col-sm-6" style="background-color:aliceblue; margin-top: 5px">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-lg btn-primary pull-right" OnClick="btnLogout_Click" />
                </div>
            </div>
        </div>
        <div class="container main-container">
            <asp:Literal ID="isAuth" runat="server"></asp:Literal>
            <asp:Literal ID="userIdLiteral" runat="server"></asp:Literal>
            
        </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../Theme/bootstrap.min.js"></script>
</body>
</html>
