using System;
using truevalueauction.App_Code;
using System.Diagnostics;
using System.Web;
using System.Web.UI;

namespace truevalueauction.Pages
{
    public partial class CreateAccount : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsername.Text = (string)Session["UserName"];

        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            

            User user = new User(txtUsername.Text, txtPassword.Text);

            user.SetFirstName(txtFirstName.Text);
            user.SetLastName(txtLastName.Text);
            user.SetEmail(txtEmail.Text);

  

            Address address = new Address(txtAdress1.Text + txtAdress2.Text, txtCity.Text, txtState.Text, txtZipCode.Text);

            user.SetAddress(address);

            bool userNameValid =  LoginValidator.UserNameIsValid(user, true);
            bool passwordValid =  LoginValidator.PasswordIsValid(user, true);

            if(userNameValid && passwordValid)
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}