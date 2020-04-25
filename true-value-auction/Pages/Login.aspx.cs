using System;
using System.Collections.Generic;
using truevalueauction.App_Code;
using IValidator = truevalueauction.App_Code.IValidator;

namespace truevalueauction.Pages
{

    public partial class Login : System.Web.UI.Page
    {

        IValidator v;
        User user;
        List<InputTypes> error = new List<InputTypes>();

        protected void Page_Load(object sender, EventArgs e)
        {
            ClientScript.GetPostBackEventReference(this, string.Empty);
            if (!Page.IsPostBack)
            {
                v = new LoginValidator(new User(), false);
            }

            string target = Request["__EVENTTARGET"];
            if (target == "btn")
            {
                v = new AccountValidator(new App_Code.User());
                btnRegister_Click(sender, e);
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            v.SetUser(new User(txtEmail.Text, txtPassword.Text));

            bool emailValid = v.IsValid(InputTypes.Email);
            bool passwordValid = v.IsValid(InputTypes.Password);


            if (emailValid && passwordValid)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                alertBody.Text = "<div ID=\"alert\" class=\"alert alert-danger\">Please enter a valid Username / Password</div>";
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

            bool valid = false;

            user = new User(txtRegisterEmail.Text, txtRegisterPassword.Text);
            user.SetFirstName(txtRegisterFirstName.Text);
            v.SetUser(user);
            try
            {
                if (txtRegisterPassword.Text != txtRegisterConfirmPassword.Text)
                {
                    throw new ArgumentException("Test");
                }

                InputTypes[] modalTypes = { InputTypes.FirstName, InputTypes.Email, InputTypes.Password };
                foreach (InputTypes type in modalTypes)
                {
                    valid = v.IsValid(type);
                    if (!valid) error.Add(type);
                }

                if (error.Count == 0 && valid)
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    throw new ArgumentException("Please enter a valid input for each box");
                }

            }
            catch (ArgumentException ex)
            {
                alertBody.Text = "<div ID=\"alert\" class=\"alert alert-danger\"> Registration Error: " + ex.Message + "</div>";

            }

        }
    }
}
