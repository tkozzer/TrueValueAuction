using truevalueauction.App_Code;
using System;

namespace truevalueauction.App_Code
{
    public class LoginValidator
    {

        /**
         * Check to see the user is already registered or if it is a new
         * user then it will check to make sure that the username is a
         * valid entry
         *
         * <param name="user">User object, must not be null</param>
         * <param name="newUser">bool to check if it's a new user</param>
         *
         * <exception cref="ArgumentException">thrown if user is null</exception>
         *
         * 
         */
        public static bool UserNameIsValid(User user, bool newUser)
        {
            string userName;
            bool letter = true, length = true ;

            if (user == null) throw new ArgumentException();
            userName = user.GetUserName();
            if (userName == string.Empty) return false;

            bool valid = true;
            if (newUser)
            {
                if (!char.IsLetter(userName[0]))
                {
                    letter = false;
                }
                if (userName.Length < 6)
                {
                    length = false;
                }
                valid = letter && length;
            }
            else
            {
                // Code for checking the database to see if user exists
            }


            return valid;
        }

        /*
         * Check to see if the password is atleast 8 character long, has an atleast
         * uppercase, symbol, and a number
         *
         */
        public static bool PasswordIsValid(User user, bool newUser)
        {
            string password;
            bool symbol, number, upper, valid;

            if (user == null) throw new ArgumentException();
            password = user.GetPassword();
            if (password == string.Empty) return false;

            valid = true;
            if (newUser)
            {
                symbol = checkString(password, "symbol");
                number = checkString(password, "number");
                upper = checkString(password, "upper");
                valid = (symbol && number && upper);
            }
            else
            {
                // Code for checking the database to see if user exists
            }

            return valid;
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

