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

        protected bool CheckDatabase(InputTypes type)
        {
            if(type == InputTypes.Email)
            {
                return true;
            }
            
            // Dummy code until database is configured
            //if(type == InputTypes.Email)
            //{
            //    return user.GetEmail() != string.Empty ? true : false;

            //} else
            //{
            //    return user.GetPassword() != string.Empty ? true : false;
            //}
            return false;
        }

        public abstract void SetNewUser(bool newUser);
        public abstract User GetUser();
        public abstract void SetUser(User user);
        public abstract bool EmailExists();

    }
}
