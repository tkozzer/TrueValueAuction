<%@ Page Language="C#" CodeBehind="AddNewItem.aspx.cs" Inherits="truevalueauction.Pages.AddNewItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Theme/bootstrap.min.css" rel="stylesheet" />
    <link href="../Theme/home.css" rel="stylesheet" />
    <title>Add New Item</title>
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
                    <asp:Button ID="btnProfile" runat="server" Text="Profile" CssClass="btn btn-lg btn-primary pull-right" Style="margin-right: 5px" OnClick="btnProfile_Click" />
                    <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btn btn-lg btn-primary pull-right" Style="margin-right: 5px" OnClick="btnHome_Click" />
                </div>
            </div>
        </div>
        <div id="container1" class="container main-container">
            <asp:Literal ID="alertNewItem" runat="server"></asp:Literal>
            <div id="form-group1" class="form-group">
                <label>Item Name</label>
                <asp:TextBox  id="txtItemName" type="text" class="form-control" runat="server"></asp:TextBox>
                <label>Description</label>
                <asp:TextBox id="txtDescription" class="form-control" rows="4" cols="10" runat="server" TextMode="MultiLine"></asp:TextBox>
                <label>Auction Length (# of days)</label>
                <asp:TextBox ID="txtAuctionLength" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                <label>Condition</label>
                <asp:DropDownList ID="ddCondition" CssClass="form-control" runat="server">
                    <asp:ListItem>Perfect</asp:ListItem>
                    <asp:ListItem>Excellent</asp:ListItem>
                    <asp:ListItem>Fair</asp:ListItem>
                    <asp:ListItem>Moderate</asp:ListItem>
                    <asp:ListItem>Damaged/For Parts</asp:ListItem>
                </asp:DropDownList>
                <label>Bid Starting Price</label>
                <asp:TextBox id="txtStartBid" TextMode="Number" class="form-control"  runat="server"></asp:TextBox>
                <label>Add a Photo</label>
                <asp:FileUpload ID="fileUpload" runat="server" CssClass="form-control" />
            </div>
            <input id="btnSubmit" type="button" value="Submit" class="btn btn-primary"  />
        </div>
    </form>
    <script src="../Scripts/addnewitem.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../Theme/bootstrap.min.js"></script>
</body>
</html>
