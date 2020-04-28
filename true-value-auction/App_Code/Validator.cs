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
            if (!newUser)
            {
                CheckDatabase();
            }

            Regex re = new Regex(InputTypeValue.Value(type));
            
            switch (type)
            {
                case InputTypes.Email:
                    return RegexUtilities.IsValidEmail(user.GetEmail());
                case InputTypes.Password:
                    return re.IsMatch(user.GetPassword());
                default: return false;
            }

        }

        protected bool CheckDatabase()
        {
            if(!newUser)
            {
                return Database.ValidateUser(user);
            }
            else
            {
                return Database.UserExists(user);
            }
            // Dummy code until database is configured
            //if(type == InputTypes.Email)
            //{
            //    return user.GetEmail() != string.Empty ? true : false;

            //} else
            //{
            //    return user.GetPassword() != string.Empty ? true : false;
            //}
            
        }

        public abstract void SetNewUser(bool newUser);
        public abstract User GetUser();
        public abstract void SetUser(User user);
        public abstract bool EmailExists();
        public abstract bool UserValid();

    }
}
