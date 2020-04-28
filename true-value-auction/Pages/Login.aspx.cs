using System;
using System.Collections.Generic;
using System.Web;
using truevalueauction.App_Code;
using IValidator = truevalueauction.App_Code.IValidator;

namespace truevalueauction.Pages
{

    public partial class Login : System.Web.UI.Page
    {

        IValidator v;
        User user;
        List<InputTypes> errors = new List<InputTypes>();
        HttpCookie userInfo = new HttpCookie("userInfo");

        protected void Page_Load(object sender, EventArgs e)
        {
            ClientScript.GetPostBackEventReference(this, string.Empty);
            if (!Page.IsPostBack)
            {
                v = new LoginValidator(new User(), false);
            }

            string target = Request["__EVENTTARGET"];
            if (target == "btnRegister")
            {
                v = new AccountValidator(new App_Code.User());
                btnRegister_Click(sender, e);
            }
            else if (target == "btnLogin")
            {
                v = new LoginValidator(new User(), false);
                btnLogin_Click(sender, e);
            }
            else
            {
                v = new LoginValidator(new App_Code.User(), false);
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            v.SetUser(new User(txtEmail.Text, txtPassword.Text));

            try
            {
                bool userValid = v.UserValid();

                if (userValid)
                {
                    Int32 userId = Database.UserId(v.GetUser());
                    userInfo["isAuth"] = "true";
                    userInfo["userId"] = userId.ToString();
                    userInfo.Expires = DateTime.Now.AddMinutes(10);
                    if (userId == 0) throw new Exception("This user does not exist");
                    Response.Cookies.Add(userInfo);
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    throw new Exception("Please enter a valid Email/Password");

                }
            }
            catch (Exception ex)
            {
                alertBody.Text = "<div ID=\"alert\" class=\"alert alert-danger\">" + ex.Message + "</div>";

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
                    throw new ArgumentException("Please make sure your passwords match");
                }

                InputTypes[] modalTypes = { InputTypes.FirstName, InputTypes.Email, InputTypes.Password };
                foreach (InputTypes type in modalTypes)
                {
                    valid = v.IsValid(type);
                    if (!valid) errors.Add(type);
                }

                if (v.EmailExists())
                {
                    throw new ArgumentException("This email already exists");
                }

                if (errors.Count == 0 && valid)
                {
                    Account.CreateAccount(user);
                    Int32 userId = Database.UserId(v.GetUser());
                    userInfo["isAuth"] = "true";
                    userInfo["userId"] = userId.ToString();
                    userInfo.Expires = DateTime.Now.AddMinutes(10);
                    if (userId == 0) throw new Exception("This user does not exist");
                    Response.Cookies.Add(userInfo);
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    foreach(InputTypes error in errors)
                    {
                        if(error == InputTypes.FirstName)
                        {
                            throw new ArgumentException("Please make sure the first name field doesn't contain any numbers");
                        }
                    }
                    throw new ArgumentException("Please enter a valid input for each box");
                }

            }
            catch (ArgumentException ex)
            {
                alertBody.Text = "<div ID=\"alert\" class=\"alert alert-danger\"><div class:\"h3\"><strong> Registration Error </strong></div>" + ex.Message + "</div>";

            }

        }
    }
}
