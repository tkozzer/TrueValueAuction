<%@ Page Language="C#" CodeBehind="CreateAccount.aspx.cs" Inherits="truevalueauction.Pages.CreateAccount" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="~/Theme/createaccount.css" type="text/css">    
    <title>Register</title>
</head>
<body>
    <form class="main" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td><h1>Register</h1></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1"></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1"></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <table class="auto-style13">
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style11">
                    <span>First Name:</span>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtFirstName" runat="server" InputType="FirstName" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblFirstNameError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <span>Last Name:</span>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtLastName" runat="server" InputType="LastName" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblLastNameError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <span>Email:</span>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtEmail" runat="server" InputType="Email" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblEmailError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <span>Username:</span>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtUsername" runat="server" InputType="Username" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblUsernameError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style11"></td>
                <td class="auto-style9"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <span>Address Line 1:</span>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtAdress1" runat="server" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblAddressLine1Error" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <span>Address Line 2:</span>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtAdress2" runat="server" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblAddressLine2Error" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <span>City:</span>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtCity" runat="server" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblCityError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <span>State:</span>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtState" runat="server" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblStateError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <span>Zip Code:</span>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtZipCode" runat="server" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblZipCodeError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Label ID="lblFullAddressError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <span>Password:</span>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblPasswordError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <span>Confirm Password:</span>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="un"></asp:TextBox>
                    <asp:Label ID="lblConfirmPassword" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style15"> <asp:Button ID="btnCreateAccount" runat="server" CssClass="submit" Text="Create Account" OnClick="btnCreateAccount_Click" /></td>
                <td class="auto-style17"></td>
                <td class="auto-style14"></td>
            </tr>
            <tr>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style18">
                    <asp:Label ID="lblGeneralError" Width="100%" Style="align-content:center" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
