using System;
namespace truevalueauction.App_Code
{
    public class AccountValidator : Validator
    {
        public AccountValidator(User user) : base(user)
        {
            SetNewUser(true);
        }

        public override User GetUser()
        {
            return user;
        }

        public override void SetUser(User user)
        {
            this.user = user;
        }

        public override void SetNewUser(bool newUser)
        {
            this.newUser = newUser;
        }

        public override bool IsValid(params InputTypes[] inputTypes)
        {
            bool valid = false;

            //foreach (InputTypes input in inputTypes)
            //{
            //    if (input is App_Code.InputTypes.Username || input is App_Code.InputTypes.Password)
            //    {
            //        //LoginValidator lv = new LoginValidator(this.user, true);
            //        //valid = lv.IsValid(input);
            //    }
            //    else
            //    {
            //        valid = CheckValidity(input);
            //    }
            //}
            return valid;
        }

        private bool CheckValidity(InputTypes input)
        {
            bool valid = false;

            switch(input)
            {
                case InputTypes.FirstName:
                case InputTypes.LastName:
                    CheckName(input);
                    break;
                case InputTypes.Email:

                    break;
                case InputTypes.Address1:
                    break;
                case InputTypes.Address2:
                    break;
                case InputTypes.City:
                    break;
                case InputTypes.State:
                    break;
                case InputTypes.ZipCode:
                    break;
                default:
                    throw new ArgumentException();
            }

            return valid;
        }

        private bool CheckName(InputTypes input)
        {
            string firstName = user.GetFirstName();
            string lastName = user.GetLastName();
            bool valid = false;

            if(input == InputTypes.FirstName)
            {
                valid = !CheckString(CheckTypes.Symbol);
            }

            if(input == InputTypes.LastName)
            {

            }
            return valid;
        }
    }
}
