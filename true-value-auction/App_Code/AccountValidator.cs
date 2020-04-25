using System;
using System.Text.RegularExpressions;
using truevalueauction.App_Code.Utilities;
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

        public override bool EmailExists()
        {
            return CheckDatabase(InputTypes.Email); 
        }

        public override bool IsValid(InputTypes type)
        {
            if (type == InputTypes.Email || type == InputTypes.Password) return base.IsValid(type);
            Regex re = new Regex(InputTypeValue.Value(type));
            switch (type)
            {
                case InputTypes.FirstName:
                    return re.IsMatch(user.GetFirstName());
                case InputTypes.LastName:
                    return re.IsMatch(user.GetLastName());
                case InputTypes.FullAddress:
                    return AddressAPI.IsAddressValid(user);
                default:
                    return false;
            }

        }

    }
}
