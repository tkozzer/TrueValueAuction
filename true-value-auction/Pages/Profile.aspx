<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="truevalueauction.Pages.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Theme/bootstrap.min.css" rel="stylesheet" />
    <link href="../Theme/home.css" rel="stylesheet" />
    <title>Profile</title>
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
                    <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btn btn-lg btn-primary pull-right" Style="margin-right: 5px" OnClick="btnHome_Click" />
                </div>
            </div>
            <div>

                <!-- Nav tabs -->
                <ul class="nav nav-tabs" role="tablist">
                    <li role="presentation" class="active"><a href="#userInfo" aria-controls="userInfo" role="tab" data-toggle="tab">User Infomation</a></li>
                    <li role="presentation"><a href="#addressInfo" aria-controls="addressInfo" role="tab" data-toggle="tab">Address Information</a></li>
                    <li role="presentation"><a href="#itemInfo" aria-controls="itemInfo" role="tab" data-toggle="tab">Item Information</a></li>
                    <li role="presentation"><a href="#bidInfo" aria-controls="bidInfo" role="tab" data-toggle="tab">Bid Infomation</a></li>
                </ul>
            </div>
        </div>
        <div id="container1" class="container main-container">
            <div id="placeholder" class="hidden"></div>
            <asp:Literal ID="alertViewItem" runat="server"></asp:Literal>
            <!-- Tab panes -->
            <div class="tab-content">
                <div role="tabpanel" class="tab-pane active" id="userInfo">
                    <asp:FormView ID="userForm" runat="server" DataSourceID="UsersData">
                        <ItemTemplate>
                            Email:
                    <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
                            <br />
                            Password:
                    <asp:Label ID="PasswordLabel" runat="server" Text='<%# Bind("Password") %>' />
                            <br />
                            FirstName:
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Bind("FirstName") %>' />
                            <br />
                            LastName:
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Bind("LastName") %>' />
                            <br />
                            RegisterDate:
                    <asp:Label ID="RegisterDateLabel" runat="server" Text='<%# Bind("RegisterDate") %>' />
                            <br />

                        </ItemTemplate>
                    </asp:FormView>
                </div>
                <div role="tabpanel" class="tab-pane" id="addressInfo">
                    <asp:FormView ID="AddressForm" runat="server" DataKeyNames="AddressId" DataSourceID="AddressData">
                        <ItemTemplate>
                            AddressId:
                    <asp:Label ID="AddressIdLabel" runat="server" Text='<%# Eval("AddressId") %>' />
                            <br />
                            Address1:
                    <asp:Label ID="Address1Label" runat="server" Text='<%# Bind("Address1") %>' />
                            <br />
                            Address2:
                    <asp:Label ID="Address2Label" runat="server" Text='<%# Bind("Address2") %>' />
                            <br />
                            Address3:
                    <asp:Label ID="Address3Label" runat="server" Text='<%# Bind("Address3") %>' />
                            <br />
                            City:
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Bind("City") %>' />
                            <br />
                            State:
                    <asp:Label ID="StateLabel" runat="server" Text='<%# Bind("State") %>' />
                            <br />
                            Country:
                    <asp:Label ID="CountryLabel" runat="server" Text='<%# Bind("Country") %>' />
                            <br />
                            ZipCode:
                    <asp:Label ID="ZipCodeLabel" runat="server" Text='<%# Bind("ZipCode") %>' />
                            <br />
                            UserId:
                    <asp:Label ID="UserIdLabel" runat="server" Text='<%# Bind("UserId") %>' />
                            <br />
                        </ItemTemplate>
                    </asp:FormView>
                </div>
                <div role="tabpanel" class="tab-pane" id="itemInfo">
                    <asp:ListView ID="ItemForm" runat="server" DataSourceID="ItemData">
                        <ItemTemplate>
                            ItemName:
                    <asp:Label ID="ItemNameLabel" runat="server" Text='<%# Bind("ItemName") %>' />
                            <br />
                            Description:
                    <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Bind("Description") %>' />
                            <br />
                            StartingPrice:
                    <asp:Label ID="StartingPriceLabel" runat="server" Text='<%# Bind("StartingPrice") %>' />
                            <br />
                            AuctionLength:
                    <asp:Label ID="AuctionLengthLabel" runat="server" Text='<%# Bind("AuctionLength") %>' />
                            <br />
                            ImageURL:
                    <asp:Label ID="ImageURLLabel" runat="server" Text='<%# Bind("ImageURL") %>' />
                            <br />
                            DateAdded:
                    <asp:Label ID="DateAddedLabel" runat="server" Text='<%# Bind("DateAdded") %>' />
                            <br />
                            UserId:
                    <asp:Label ID="UserIdLabel" runat="server" Text='<%# Bind("UserId") %>' />
                            <br />
                            ItemCondition:
                    <asp:Label ID="ItemConditionLabel" runat="server" Text='<%# Bind("ItemCondition") %>' />
                            <br />
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div role="tabpanel" class="tab-pane" id="bidInfo">
                    <asp:GridView ID="Bids" runat="server"></asp:GridView>
                </div>
            </div>
        </div>
        <asp:SqlDataSource ID="UsersData" runat="server" ConnectionString="<%$ ConnectionStrings:Users %>" SelectCommand="SELECT [Email], [Password], [FirstName], [LastName], [RegisterDate] FROM [Users] WHERE ([UserId] = @UserId)">
            <SelectParameters>
                <asp:CookieParameter CookieName="userId" DefaultValue="" Name="UserId" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="ItemData" runat="server" ConnectionString="<%$ ConnectionStrings:Users %>" SelectCommand="SELECT [ItemName], [Description], [StartingPrice], [AuctionLength], [ImageURL], [DateAdded], [UserId], [ItemCondition] FROM [Items] WHERE ([UserId] = @UserId)">
            <SelectParameters>
                <asp:CookieParameter CookieName="userId" Name="UserId" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="AddressData" runat="server" ConnectionString="<%$ ConnectionStrings:Users %>" SelectCommand="SELECT * FROM [Address] WHERE ([UserId] = @UserId)">
            <SelectParameters>
                <asp:CookieParameter CookieName="userId" Name="UserId" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="BidData" runat="server"></asp:SqlDataSource>
    </form>
    <script src="../Scripts/home.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../Theme/bootstrap.min.js"></script>
</body>
</html>
