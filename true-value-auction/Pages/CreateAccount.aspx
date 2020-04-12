<%@ Page Language="C#" CodeBehind="CreateAccount.aspx.cs" Inherits="truevalueauction.Pages.CreateAccount" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <style type="text/css">
        .auto-style1 {
            width: 102px;
        }
        .auto-style3 {
            height: 23px;
            width: 458px;
        }
        .auto-style4 {
            width: 458px;
        }
        .auto-style7 {
            height: 23px;
            width: 617px;
        }
        .auto-style8 {
            width: 617px;
        }
        .auto-style9 {
            height: 23px;
            width: 367px;
        }
        .auto-style10 {
            width: 367px;
        }
        .auto-style11 {
            height: 23px;
            width: 349px;
        }
        .auto-style12 {
            width: 349px;
        }
        .auto-style13 {
            width: 100%;
        }
        .auto-style14 {
            height: 23px;
        }
        .auto-style15 {
            height: 23px;
            width: 775px;
        }
        .auto-style16 {
            width: 775px;
        }
        .auto-style17 {
            height: 23px;
            width: 321px;
        }
        .auto-style18 {
            width: 321px;
            align-content: center;
        }
        .auto-style19 {
            margin-left: 126px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="lblCreate" runat="server" Text="Create Account"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
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
                    <asp:TextBox ID="txtFirstName" runat="server" InputType="FirstName"></asp:TextBox>
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
                    <asp:TextBox ID="txtLastName" runat="server" InputType="LastName"></asp:TextBox>
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
                    <asp:TextBox ID="txtEmail" runat="server" InputType="Email"></asp:TextBox>
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
                    <asp:TextBox ID="txtUsername" runat="server" InputType="Username"></asp:TextBox>
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
                    <asp:TextBox ID="txtAdress1" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="txtAdress2" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" InputType="Password"></asp:TextBox>
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
                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" InputType="ConfirmPassword"></asp:TextBox>
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
                <td class="auto-style15"></td>
                <td class="auto-style17">
                    <asp:Button ID="btnCreateAccount" runat="server" CssClass="auto-style19" Text="Create Account" OnClick="btnCreateAccount_Click" />
                </td>
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
