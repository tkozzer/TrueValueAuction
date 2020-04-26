<%@ Page Language="C#" Inherits="truevalueauction.Pages.Home" CodeBehind="~/Pages/Home.aspx.cs" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Welcome to True Value Auction</h1>
        <asp:Literal ID="isAuth" runat="server"></asp:Literal>
        <asp:Literal ID="userIdLiteral" runat="server"></asp:Literal>
    </form>
</body>
</html>
