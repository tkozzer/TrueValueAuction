using System;
namespace truevalueauction.App_Code
{
    public abstract class Validator : IValidator
    {
        protected User user;
        protected bool newUser;

        public Validator(User user)
        {
            this.user = user;
    
        }

        public abstract void SetNewUser(bool newUser);
        public abstract User GetUser();
        public abstract void SetUser(User user);
        public abstract bool IsValid(params InputTypes[] inputTypes);

    }
}
