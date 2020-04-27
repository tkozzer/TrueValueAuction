<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewItem.aspx.cs" Inherits="truevalueauction.Pages.ViewItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 113px;
        }
        .auto-style2 {
            width: 108px;
        }
        .auto-style3 {
            width: 113px;
            height: 23px;
        }
        .auto-style4 {
            width: 108px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 329px;
        }
        .auto-style7 {
            width: 329px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            VIEW ITEM</div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="lblItemName" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style7"></td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Image ID="Image1" runat="server" Height="235px" Width="312px" ImageUrl="~/App_Data/dsc07890_1.jpg" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td>Current Bid:
                    <asp:Label ID="lblCurrentBid" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="lblBidError" runat="server" ForeColor="#FF3300"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>Interested? Bid on this item:</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtNewBid" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit Bid" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>Description:
                    <asp:Label ID="lblDescription" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
