using System;
using truevalueauction.App_Code;
using System.Web;
using System.Web.UI;

namespace truevalueauction.Pages
{
    public partial class CreateAccount : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            User user = new User(txtUsername.Text, txtPassword.Text);

            user.SetFirstName(txtFirstName.Text);
            user.SetLastName(txtLastName.Text);
            user.SetEmail(txtEmail.Text);

            Address address = new Address(txtAdress1.Text + txtAdress2.Text, txtCity.Text, txtState.Text, txtZipCode.Text);

            user.SetAddress(address);

            bool userNameValid = LoginValidator.userNameIsValid(user);
            bool passwordValid = LoginValidator.passwordIsValid(user);

            if(userNameValid && passwordValid)
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}