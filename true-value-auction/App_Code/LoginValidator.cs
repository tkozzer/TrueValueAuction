using truevalueauction.App_Code;
using System;

namespace truevalueauction.App_Code
{
    public class LoginValidator : Validator
    {
        

        public LoginValidator(User user) : base(user)
        {
            this.newUser = true;

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

        /**
         * <summary>Check to see the user is already registered or if it is a new
         * user then it will check to make sure that the username is a
         * valid entry</summary>
         *
         * <param name="user">User object, must not be null</param>
         * <param name="newUser">bool to check if it's a new user</param>
         *
         * <exception cref="ArgumentException">thrown if user is null</exception>
         *
         * 
         */
        private bool CheckUserName()
        {

            string userName;
            bool letter = true, length = true , hasSymbol = false;

            if (user == null) throw new ArgumentException();
            userName = user.GetUserName();
            if (userName == string.Empty) return false;

            bool valid = false;
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

                hasSymbol = CheckString(CheckTypes.Symbol);

                valid = letter && length && !hasSymbol;
            }
            else
            {
                // Code for checking the database to see if user exists
            }


            return valid;
        }

        /**
         * <summary>Check to see if the password is atleast 8 character long, has an atleast
         * uppercase, symbol, and a number</summary>
         *
         */
        private bool CheckPassword()
        {
            string password;
            bool symbol, number, upper, lower, valid;

            if (user == null) throw new ArgumentException();
            password = user.GetPassword();
            if (password == string.Empty) return false;

            valid = false;
            if (newUser)
            {
                symbol = CheckString(CheckTypes.Symbol);
                number = CheckString(CheckTypes.Number);
                upper = CheckString(CheckTypes.Upper);
                lower = CheckString(CheckTypes.Lower);
                valid = (symbol && number && upper && lower);
            }
            else
            {
                // Code for checking the database to see if user exists
            }

            return valid;
        }

        public override bool IsValid(params InputTypes[] inputTypes)
        {
            bool valid = false;
            foreach(InputTypes element in inputTypes)
            {
                switch(element)
                {
                    case InputTypes.Username:
                        valid = CheckUserName();
                        break;
                    case InputTypes.Password:
                        valid = CheckPassword();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            return valid;
        }


    }
}

