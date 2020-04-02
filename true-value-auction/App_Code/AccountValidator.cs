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

        public override bool IsValid(params InputTypes[] inputTypes)
        {
            return true;
        }

        public override void SetNewUser(bool newUser)
        {
            this.newUser = newUser;
        }
    }
}
