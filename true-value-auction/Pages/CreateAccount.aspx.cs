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
        List<Control> textBoxes = new List<Control>();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsername.Text = (string)Session["UserName"];
            v = new AccountValidator((User)Session["User"]);
            v.SetNewUser(true);
            AddTextBoxes();
            Debug.WriteLine(textBoxes.Count);
        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {

            v.SetUser(new User(txtUsername.Text, txtPassword.Text));
            User user = v.GetUser();
            user.SetFirstName(txtFirstName.Text);
            user.SetLastName(txtLastName.Text);
            user.SetEmail(txtEmail.Text);
            Address address = new Address(txtAdress1.Text + txtAdress2.Text, txtCity.Text, txtState.Text, txtZipCode.Text);
            user.SetAddress(address);

            string inputTypeStr;
            InputTypes inputType;
            bool valid = false;
            List<InputTypes> error = new List<InputTypes>();
            foreach(Control tb in textBoxes)
            {
                inputTypeStr = ((TextBox)tb).Attributes["InputType"];
                try
                {
                    inputType = (InputTypes)Enum.Parse(typeof(InputTypes), inputTypeStr, true);
                    valid = v.IsValid(inputType);
                    if (!valid) error.Add(inputType);
                } catch (ArgumentException)
                {
                    Debug.WriteLine(inputTypeStr);
                    continue;
                }

            }

            if (valid)
            {
                Response.Redirect("Home.aspx");
            }
        }

        private void AddTextBoxes()
        {
            
            foreach (Control tb in Page.Controls)
            {
                if(tb is TextBox)
                {
                    textBoxes.Add(tb);
                }
                foreach(Control next_tb in tb.Controls)
                {
                    if (next_tb is TextBox)
                    {
                        textBoxes.Add(next_tb);
                    }
                }
            }
        }
    }
}