<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllItems.aspx.cs" Inherits="truevalueauction.Pages.ViewAllItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View All Items<asp:GridView ID="grdVwItems" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="NewItemDataSource" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
                    <asp:BoundField DataField="StartingPrice" HeaderText="StartingPrice" SortExpression="StartingPrice" />
                    <asp:BoundField DataField="LengthDays" HeaderText="LengthDays" SortExpression="LengthDays" />
                    <asp:BoundField DataField="dateAdded" HeaderText="dateAdded" SortExpression="dateAdded" />
                    <asp:BoundField DataField="CreatorID" HeaderText="CreatorID" SortExpression="CreatorID" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="NewItemDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ItemName], [StartingPrice], [LengthDays], [dateAdded], [CreatorID] FROM [Item] ORDER BY [dateAdded]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="UsersDb" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ItemName], [Description], [LengthDays], [ShipCost], [StartingPrice] FROM [Item]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
