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

        public enum CheckTypes { Symbol, Upper, Number, Email, Lower }

        protected bool CheckString(CheckTypes type)
        {
            string password = user.GetPassword();
            switch (type)
            {
                case CheckTypes.Symbol:
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (char.IsSymbol(password[i]) || char.IsPunctuation(password[i]))
                        {
                            return true;
                        }
                    }
                    break;
                case CheckTypes.Upper:
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (char.IsUpper(password[i]))
                        {
                            return true;
                        }
                    }
                    break;
                case CheckTypes.Number:
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (char.IsNumber(password[i]))
                        {
                            return true;
                        }
                    }
                    break;
                case CheckTypes.Email:
                    break;
                case CheckTypes.Lower:
                    break;
            }
            return false;
        }

        public abstract void SetNewUser(bool newUser);
        public abstract User GetUser();
        public abstract void SetUser(User user);
        public abstract bool IsValid(params InputTypes[] inputTypes);

    }
}
