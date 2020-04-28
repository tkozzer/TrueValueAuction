using System;
using truevalueauction.App_Code;
using System.Diagnostics;
using System.Web;
using System.Web.UI;
using IValidator = truevalueauction.App_Code.IValidator;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace truevalueauction.Pages
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        IValidator v;
        User user;
        List<InputTypes> error = new List<InputTypes>();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty((string)Session["Username"]))
            {
                Debug.WriteLine("Session is empty");
            }

            if (txtUsername.Text != string.Empty)
            {
                Session["Username"] = txtUsername.Text;
            }

            v = new AccountValidator(user);
        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            bool valid = false;
            user = new User(txtUsername.Text, txtPassword.Text);
            user.SetFirstName(txtFirstName.Text);
            user.SetLastName(txtLastName.Text);
            user.SetEmail(txtEmail.Text);

            Address address = new Address(txtAdress1.Text, txtAdress2.Text, txtCity.Text, txtState.Text, txtZipCode.Text);

            user.SetAddress(address);

            if (user.GetPassword() != txtConfirmPassword.Text) error.Add(InputTypes.ConfirmPassword);

            InputTypes[] totalTypes = { InputTypes.Email, InputTypes.FirstName, InputTypes.LastName, InputTypes.Email, InputTypes.FullAddress, InputTypes.Password };
            v.SetUser(user);
            foreach(InputTypes type in totalTypes)
            {
                valid = v.IsValid(type);
                if (!valid) error.Add(type);
            }


            if (valid && error.Count == 0)
            {
                Response.Redirect("Home.aspx");
            } else
            {
                //TODO: v.HandleErrors(error);
            }
        }

    }
}