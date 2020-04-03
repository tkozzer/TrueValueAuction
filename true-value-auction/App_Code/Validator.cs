using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace truevalueauction.App_Code
{
    public abstract class Validator : IValidator
    {

        /*
         * This pattern requires at least two lowercase letters,
         * two uppercase letters, two digits, and two special characters.
         * There must be a minimum of 9 characters and maximum of 20 total,
         * and no white space characters are allowed.
         */
        private const string passwordRegex = @"^(?=.*[a-z].*[a-z])(?=.*[A-Z].*[A-Z])(?=.*\d.*\d)(?=.*\W.*\W)[a-zA-Z0-9\S]{9,20}$";
        protected User user;
        protected bool newUser;

        public Validator(User user)
        {
            this.user = user;
    
        }

        public enum CheckTypes { Symbol, Upper, Number, Email, Lower, Punctuation, Password }

        protected bool CheckString(params CheckTypes[] type)
        {
            string password = user.GetPassword();
            foreach(CheckTypes check in type)
            {
                switch (check)
                {
                    case CheckTypes.Symbol:

                        return password.Any(char.IsSymbol);
                        
                    case CheckTypes.Punctuation:

                        return password.Any(char.IsPunctuation);

                    case CheckTypes.Upper:

                        return password.Any(char.IsPunctuation);

                    case CheckTypes.Number:

                        return password.Any(char.IsNumber);

                    case CheckTypes.Email:
                        break;
                    case CheckTypes.Lower:
                        break;
                    case CheckTypes.Password:
                        Regex re = new Regex(passwordRegex);
                        return re.IsMatch(password);
                }
            }

            return false;
        }

        public abstract void SetNewUser(bool newUser);
        public abstract User GetUser();
        public abstract void SetUser(User user);
        public abstract bool IsValid(params InputTypes[] inputTypes);

    }
}
