using System;
using System.Diagnostics;
using truevalueauction.App_Code;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace truevalueauction.Pages
{

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("This is test");
            User user = new User(txtUsername.Text, txtPassword.Text);

            bool userNameValid = LoginValidator.UserNameIsValid(user, false);
            bool passwordValid = LoginValidator.PasswordIsValid(user, false);

            if (userNameValid && passwordValid)
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

            if (txtUsername.Text != string.Empty)
            {
                Session["UserName"] = txtUsername.Text;
            }
            Response.Redirect("CreateAccount.aspx");
            
        }
    }
}
