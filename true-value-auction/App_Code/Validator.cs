using System;
using System.Linq;
using System.Net.Mail;
using truevalueauction.App_Code.Utilities;
using truevalueauction.App_Code;
using System.Text.RegularExpressions;

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

        public virtual bool IsValid(InputTypes type)
        {

            Regex re = new Regex(InputTypeValue.Value(type));
            
            switch (type)
            {
                case InputTypes.Email:
                    return newUser ? RegexUtilities.IsValidEmail(user.GetEmail()) : CheckDatabase(type);
                case InputTypes.Password:
                    return newUser ? re.IsMatch(user.GetPassword()) : CheckDatabase(type);
                default: return false;
            }

        }

        private bool CheckDatabase(InputTypes type)
        {
            // Dummy code until database is configured
            if(type == InputTypes.Email)
            {
                return user.GetEmail() != string.Empty ? true : false;

            } else
            {
                return user.GetPassword() != string.Empty ? true : false;
            }
        }

        public abstract void SetNewUser(bool newUser);
        public abstract User GetUser();
        public abstract void SetUser(User user);

    }
}
