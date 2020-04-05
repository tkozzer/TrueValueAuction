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
            //user.SetUsername(txtUsername.Text);
            //user.SetPassword(txtPassword.Text);
            user.SetFirstName(txtFirstName.Text);
            user.SetLastName(txtLastName.Text);
            user.SetEmail(txtEmail.Text);

            Address address = new Address(txtAdress1.Text, txtAdress2.Text, txtCity.Text, txtState.Text, txtZipCode.Text);

            user.SetAddress(address);

            
            InputTypes[] totalTypes = { InputTypes.Username, InputTypes.FirstName, InputTypes.LastName, InputTypes.Email, InputTypes.FullAddress, InputTypes.Password, InputTypes.ConfirmPassword };

            foreach(InputTypes type in totalTypes)
            {
                valid = v.IsValid(type);
                if (!valid) error.Add(type);
            }

            

            //foreach(Control textBox in textBoxes)
            //{
            //    typeStr = ((TextBox)textBox).Attributes["InputType"];
            //    try
            //    {
            //        type = (InputTypes)Enum.Parse(typeof(InputTypes), typeStr, true);
            //        valid = v.IsValid(type);
            //        if (!valid) error.Add(type);
            //    } catch (ArgumentException)
            //    {
            //        Debug.WriteLine("Input type: " + typeStr);
            //        continue;
            //    }
            //}


            //string inputTypeStr;
            //InputTypes inputType;
            //bool valid = false;
            //valid = v.IsValid(InputTypes.FullAddress);
            //List<InputTypes> error = new List<InputTypes>();
            //foreach(Control tb in textBoxes)
            //{
            //    inputTypeStr = ((TextBox)tb).Attributes["InputType"];
            //    try
            //    {
            //        inputType = (InputTypes)Enum.Parse(typeof(InputTypes), inputTypeStr, true);
            //        valid = v.IsValid(inputType);
            //        if (!valid) error.Add(inputType);
            //    } catch (ArgumentException)
            //    {
            //        Debug.WriteLine(inputTypeStr);
            //        continue;
            //    }

            //}

            if (valid && error.Count == 0)
            {
                Response.Redirect("Home.aspx");
            }
        }

    }
}