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
            <asp:Literal ID="alertProfile" runat="server"></asp:Literal>
            <!-- Tab panes -->
            <div class="tab-content">
                <div role="tabpanel" class="tab-pane active" id="userInfo">
                    <asp:FormView ID="userForm" runat="server" DataSourceID="UsersData">
                        <ItemTemplate>
                            <div class="container items">
                                <div class="list-group">
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Email</strong><br />
                                            <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("Email") %>' /></span>
                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>First Name</strong><br />
                                            <asp:Label ID="lblFirstName" runat="server" Text='<%# Bind("FirstName") %>' /></span>
                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Last Name</strong><br />
                                            <asp:Label ID="lblLastname" runat="server" Text='<%# Bind("LastName") %>' /></span>
                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Member Since</strong><br />
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("RegisterDate", "{0:MMM dd, yyyy}")%>' /></span>
                                    </div>
                                    <asp:Button ID="btnEditUserInfo" CssClass="btn btn-block btn-primary" runat="server" Text="Edit" />
                                    <asp:Button ID="btnDeleteAccount" CssClass="btn btn-block btn-danger" runat="server" Text="DELETE ACCOUNT" OnClick="btnDeleteAccount_Click" />
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:FormView>
                </div>
                <div role="tabpanel" class="tab-pane" id="addressInfo">
                    <asp:FormView ID="AddressForm" runat="server" DataKeyNames="AddressId" DataSourceID="AddressData">
                        <ItemTemplate>
                            <div class="container items">
                                <div class="list-group">
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Address 1</strong>
                                        <asp:Label ID="lblAddress1" runat="server" Text='<%# Bind("Address1") %>' /></span>
                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Address 2</strong>
                                        <asp:Label ID="lblAddress2" runat="server" Text='<%# Bind("Address2") %>' /></span>
                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Address 3</strong>
                                        <asp:Label ID="lblAddress3" runat="server" Text='<%# Bind("Address3") %>' /></span>
                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>City</strong>
                                        <asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>' /></span>
                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>State</strong>
                                        <asp:Label ID="lblState" runat="server" Text='<%# Bind("State") %>' /></span>
                                    </div>
                                     <div class="list-group-item">
                                        <span class="h3"><strong>Country</strong>
                                         <asp:Label ID="lblCountry" runat="server" Text='<%# Bind("Country") %>' /></span>
                                     </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Zipcode</strong>
                                            <asp:Label ID="lblZipcode" runat="server" Text='<%# Bind("ZipCode") %>' /></span>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block" data-toggle="modal" data-target="#myModal">
                                        Edit Address
                                    </button>
                                    <asp:Button ID="btnDeleteAddress" CssClass="btn btn-block btn-danger" runat="server" Text="DELETE" />
                                </div>
                            </div>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <div class="container items">
                                <div class="list-group">
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Address 1</strong></span>

                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Address 2</strong></span>

                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Address 3</strong></span>

                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>City</strong></span>

                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>State</strong></span>

                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Country</strong></span>

                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Zipcode</strong></span>
                                    </div>
                                    <div class="list-group-item">
                                        <button type="button" class="btn btn-primary btn-block" data-toggle="modal" data-target="#myModal">
                                            Edit Address
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </EmptyDataTemplate>
                    </asp:FormView>
                </div>

                <!-- Modal -->
                <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h4 class="modal-title" id="myModalLabel">Edit Address</h4>
                            </div>
                            <div class="modal-body">
                                <div class="form-group">
                                    <label for="inputAddress">Address</label>
                                    <asp:TextBox CssClass="form-control" id="txtAddress1" placeholder="1234 Main St" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="inputAddress2">Address 2</label>
                                    <asp:TextBox CssClass="form-control" id="txtAddress2" placeholder="Apartment, studio, or floor" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <div class="form-row">
                                        <div class="form-group col-md-6">
                                            <label for="inputCity">City</label>
                                            <asp:TextBox CssClass="form-control" id="txtCity" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-4">
                                            <label for="inputState">State</label>
                                            <asp:TextBox CssClass="form-control" id="txtState" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-2">
                                            <label for="inputZip">Zip</label>
                                            <asp:TextBox  CssClass="form-control" id="txtZip" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                <asp:Button ID="btnEditAddress" runat="server" CssClass="btn btn-primary" Text="Submit Changes" />
                            </div>
                        </div>
                    </div>
                </div>

                <div role="tabpanel" class="tab-pane" id="itemInfo">
                    <asp:ListView ID="ItemForm" runat="server" DataSourceID="ItemData">
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
                                        <span class="h3"><strong>Condition</strong><br />
                                            <asp:Label ID="ItemConditionLabel" runat="server" Text='<%# Bind("ItemCondition") %>' />
                                    </div>
                                    <div class="list-group-item">
                                        <span class="h3"><strong>Time Remaining</strong><br />
                                            <asp:Label ID="AuctionLengthLabel" runat="server" Text='<%# GetTimeRemaining(Eval("AuctionLength"), Eval("DateAdded")) %>' /></span>
                                    </div>
                                    <input id="btnEdit<%# Eval("ItemId") %>" class="btn-block btn btn-primary form-inline" value="Edit" onclick="" />
                                    <input id="btnDelete<%# Eval("ItemId") %>" class="btn-block btn btn-danger" value="Delete" onclick="javascript: GetItemId(<%# Eval("ItemId")%>)" />
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div role="tabpanel" class="tab-pane" id="bidInfo">
                    <asp:ListView ID="ListView1" runat="server" DataSourceID="BidData">
                        <EmptyDataTemplate>
                            <table runat="server" style="">
                                <tr>
                                    <td>You currently don't have any bids.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <ItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Label Text='<%# Eval("ItemName") %>' runat="server" ID="lblItemName" />

                                </td>
                                <td>
                                    <asp:Label Text='<%# GetTimeRemaining(Eval("AuctionLength"),Eval("DateAdded"))  %>' runat="server" ID="lblTimeReamaining" />

                                </td>
                                <td>
                                    <asp:Label Text='<%# string.Format("{0:c}",Eval("Amount")) %>' runat="server" ID="lblBidAmount" />

                                </td>
                                <td>
                                    <asp:Label Text='<%# Eval("BidTime") %>' runat="server" ID="lblBidTime" />

                                </td>
                                <td>
                                    <asp:Label Text='<%# string.Format("{0:c}",Eval("StartingPrice")) %>' runat="server" ID="lblStartPrice" />
                                </td>
                                <td>
                                    <input id="btn<%# Eval("ItemId") %>" type="button" value="New Bid" class="btn btn-primary btn-block" />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <LayoutTemplate>
                            <table class="table table-bordered" runat="server">
                                <tr runat="server">
                                    <td runat="server">
                                        <table runat="server" id="itemPlaceholderContainer" class="table table-bordered" border="0">
                                            <tr runat="server" style="">
                                                <th runat="server">Item Name</th>
                                                <th runat="server">Time Reamaining</th>
                                                <th runat="server">Your Bid</th>
                                                <th runat="server">Bid Time</th>
                                                <th runat="server">Starting Price</th>
                                                <th runat="server">Submit New Bid</th>
                                            </tr>
                                            <tr runat="server" id="itemPlaceholder"></tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" style=""></td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                    </asp:ListView>
                </div>
            </div>
        </div>
        <asp:SqlDataSource ID="UsersData" runat="server" ConnectionString="<%$ ConnectionStrings:Users %>" SelectCommand="SELECT [Email], [Password], [FirstName], [LastName], [RegisterDate] FROM [Users] WHERE ([UserId] = @UserId)">
            <SelectParameters>
                <asp:CookieParameter CookieName="userId" DefaultValue="" Name="UserId" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="ItemData" runat="server" ConnectionString="<%$ ConnectionStrings:Users %>" SelectCommand="SELECT [ItemId], [ItemName], [Description], [StartingPrice], [AuctionLength], [ImageURL], [DateAdded], [UserId], [ItemCondition] FROM [Items] WHERE ([UserId] = @UserId)">
            <SelectParameters>
                <asp:CookieParameter CookieName="userId" Name="UserId" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="AddressData" runat="server" ConnectionString="<%$ ConnectionStrings:Users %>" SelectCommand="SELECT * FROM [Address] WHERE ([UserId] = @UserId)">
            <SelectParameters>
                <asp:CookieParameter CookieName="userId" Name="UserId" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="BidData" runat="server" ConnectionString="<%$ ConnectionStrings:Users %>" SelectCommand="SELECT Items.ItemId AS ItemId, Items.ItemName, Items.Description, Items.AuctionLength, Items.DateAdded, Bids.Amount, Bids.BidTime, Items.StartingPrice   FROM Items INNER JOIN Bids ON Items.ItemId = Bids.ItemID AND Bids.UserID = @userId">
            <SelectParameters>
                <asp:CookieParameter CookieName="userId" Name="userId" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
    <script src="../Scripts/profile.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../Theme/bootstrap.min.js"></script>
</body>
</html>
