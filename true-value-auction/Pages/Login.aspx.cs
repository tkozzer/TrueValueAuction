using System;
using truevalueauction.App_Code;
using System.Web;
using System.Web.UI;

namespace truevalueauction.Pages
{

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(txtUsername.Text, txtPassword.Text);

            bool userNameValid = LoginValidator.userNameIsValid(user);
            bool passwordValid = LoginValidator.passwordIsValid(user);

            //if (userNameValid && passwordValid)
            if(true)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblPasswordError.Text = "Please enter a valid Username/Password";
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateAccount.aspx");
        }
    }
}
