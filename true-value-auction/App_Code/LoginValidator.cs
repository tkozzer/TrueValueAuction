using truevalueauction.App_Code;
using System;

namespace truevalueauction.App_Code
{
    public class LoginValidator
    {

        /*
         * Check to make sure the the user name is atleast 6 characters and doesn't
         * start with a number or symbol
         */
        public static bool userNameIsValid(User user)
        {
            string userName = user.GetUserName();
            if (userName == string.Empty) return false;
            char first = userName[0];
            bool valid = true;

            


            if (!char.IsLetter(first))
            {
                valid = false;
            }

            if(userName.Length < 6)
            {
                valid = false;
            }

            return valid;
        }

        /*
         * Check to see if the password is atleast 8 character long, has an atleast
         * uppercase, symbol, and a number
         *
         */
        public static bool passwordIsValid(User user)
        {
            string password = user.GetPassword();
            if (password == string.Empty) return false;

            bool symbol = checkString(password, "symbol");
            bool number = checkString(password, "number");
            bool upper = checkString(password, "upper");

            return (symbol && number && upper);
        }

        public static string handleExceptions(User user)
        {

            return "test";
        }

        private static bool checkString(string password, string check)
        {
            switch(check)
            {
                case "symbol":
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (char.IsSymbol(password[i]) || char.IsPunctuation(password[i]))
                        {
                            return true;
                        }
                    }
                    break;
                case "upper":
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (char.IsUpper(password[i]))
                        {
                            return true;
                        }
                    }
                    break;
                case "number":
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (char.IsNumber(password[i]))
                        {
                            return true;
                        }
                    }
                    break;
            }
            return false;
        }








    }
}

