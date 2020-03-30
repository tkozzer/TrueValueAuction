<%@ Page Language="C#" Inherits="truevalueauction.Pages.AddNewItem" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 357px;
        }
        .auto-style3 {
            height: 23px;
            width: 357px;
        }
        .auto-style4 {
            height: 22px;
        }
        .auto-style5 {
            height: 22px;
            width: 357px;
        }
        .auto-style6 {
            height: 22px;
            width: 319px;
        }
        .auto-style7 {
            width: 319px;
        }
        .auto-style8 {
            height: 23px;
            width: 319px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style10 {
            width: 357px;
            height: 26px;
        }
        .auto-style11 {
            width: 319px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="2">Sell an Item</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">Item Name:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">General Item Description:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtDesc" runat="server" Height="95px" Width="206px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">Item Condition:</td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddCondition" runat="server">
                            <asp:ListItem>Perfect</asp:ListItem>
                            <asp:ListItem>Excellent</asp:ListItem>
                            <asp:ListItem>Fair</asp:ListItem>
                            <asp:ListItem>Moderate</asp:ListItem>
                            <asp:ListItem>Damaged/For Parts</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style3">Bid Starting Price:</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtStartingPrice" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">Bid Length in days (less than 10):</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtBidLength" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">Shipping Height</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtShipHeight" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">Shipping Length</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtShipLength" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">Shipping Depth</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtShipDepth" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">Shipping Weight</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtShipWeight" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">Shipping Cost:</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtShipCost" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">Add an image:</td>
                    <td class="auto-style7">
                        <asp:FileUpload ID="fileImage" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="86px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>