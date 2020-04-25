using System;

namespace truevalueauction.App_Code
{
    public class LoginValidator : Validator
    {
        

        public LoginValidator(User user) : base(user)
        {
            this.newUser = false;

        }

        public LoginValidator(User user, bool newUser) : this(user)
        {
            this.newUser = newUser;
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

        public override bool IsValid(InputTypes input)
        {
            if (newUser) return false;
            return base.IsValid(input);
        }

        public override bool EmailExists()
        {
            throw new NotImplementedException();
        }
    }
}

