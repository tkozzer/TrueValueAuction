using System;
using System.Diagnostics;
using truevalueauction.App_Code;
using IValidator = truevalueauction.App_Code.IValidator;

namespace truevalueauction.Pages
{

    public partial class Login : System.Web.UI.Page
    {
        IValidator v;

        protected void Page_Load(object sender, EventArgs e)
        {
            v = new LoginValidator(new User(), false);

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            v.SetUser(new User(txtUsername.Text, txtPassword.Text));

            bool userNameValid = v.IsValid(InputTypes.Username);
            bool passwordValid = v.IsValid(InputTypes.Password);


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
                Session["User"] = v.GetUser();
            }
            Session["NewUser"] = true;
            Response.Redirect("CreateAccount.aspx");
            
        }
    }
}
