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
        <nav class="navbar navbar-default navbar-fixed-top">
            <div class="container">
                <h1>Home</h1>
            </div>
        </nav>
        <br />
        <br />
        <div class="container">
            <asp:Literal ID="isAuth" runat="server"></asp:Literal>
            <asp:Literal ID="userIdLiteral" runat="server"></asp:Literal>
            <br />
            <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-lg btn-primary" OnClick="btnLogout_Click" />
        </div>

    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../Theme/bootstrap.min.js"></script>
</body>
</html>
