<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewItem.aspx.cs" Inherits="truevalueauction.Pages.ViewItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Theme/bootstrap.min.css" rel="stylesheet" />
    <link href="../Theme/home.css" rel="stylesheet" />
    <title><%# Eval("ItemName") %></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-static-top nav-main" style="background-color: #e0e0e0">
            <div class="row" style="margin: 10px 10px 0px 10px">
                <div class="col-sm-6">
                    <h1><strong>True Value Auction</strong></h1>
                </div>
                <div class="col-sm-6" style="margin-top: 10px">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-lg btn-primary pull-right" OnClick="btnLogout_Click" />
                    <asp:Button ID="btnProfile" runat="server" Text="Profile" CssClass="btn btn-lg btn-primary pull-right" Style="margin-right: 5px" />
                    <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btn btn-lg btn-primary pull-right" Style="margin-right: 5px" OnClick="btnHome_Click" />
                </div>
            </div>
        </div>
        <div class="container main-container">
            <asp:Literal ID="alertViewItem" runat="server"></asp:Literal>
            <asp:ListView ID="ListItems" runat="server" DataSourceID="UsersDB">
                <ItemTemplate>
                    <div class="container items">
                        <div class="list-group">
                            <div class="list-group-item">
                                <strong class="h1">
                                    <asp:Label ID="ItemNameLabel" runat="server" Text='<%# Eval("ItemName") %>' /></strong>
                            </div>
                            <div class="list-group-item">
                                <span class="h3"><strong>Description</strong><br />
                                    <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' /></span>
                            </div>
                            <div class="list-group-item">
                                <span class="h3"><strong>Starting Price</strong><br />
                                    <asp:Label ID="StartingPriceLabel" runat="server" Text='<%# string.Format("{0:c}",Eval("StartingPrice")) %>' /></span>
                            </div>
                            <div class="list-group-item">
                                <span class="h3"><strong>Time Remaining</strong><br />
                                    <asp:Label ID="AuctionLengthLabel" runat="server" Text='<%# GetTimeRemaining(Eval("AuctionLength"), Eval("DateAdded")) %>' /></span>
                            </div>
                            <div class="list-group-item">
                                <input id="btnBid" class="btn-block btn btn-primary" value="Bid Now!" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <asp:SqlDataSource ID="UsersDB" runat="server" ConnectionString="<%$ ConnectionStrings:Users %>" SelectCommand="SELECT * FROM [Items] WHERE ([ItemId] = @ItemId)">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="" Name="ItemId" QueryStringField="itemId" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
    <script src="../Scripts/home.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../Theme/bootstrap.min.js"></script>
</body>
</html>
