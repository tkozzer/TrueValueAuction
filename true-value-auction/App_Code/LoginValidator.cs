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
            throw new NotImplementedException();
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
        private bool CheckUserName(bool newUser)
        {
            this.newUser = newUser;
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

        /**
         * <summary>Check to see if the password is atleast 8 character long, has an atleast
         * uppercase, symbol, and a number</summary>
         *
         */
        private bool CheckPassword(bool newUser)
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

        public override bool IsValid(params InputTypes[] inputTypes)
        {
            bool isValid = false;
            foreach(InputTypes element in inputTypes)
            {
                switch(element)
                {
                    case InputTypes.Username:
                        isValid = CheckUserName(this.newUser);
                        break;
                    case InputTypes.Password:
                        isValid = CheckPassword(this.newUser);
                        break;
                    //case InputTypes.FirstName:
                    //    isValid = CheckFirstName();
                    //    break;
                    //case InputTypes.LastName:
                    //    isValid = CheckUserName();
                    //    break;
                    default:
                        throw new ArgumentException();
                }
            }
            return isValid;
        }


    }
}

