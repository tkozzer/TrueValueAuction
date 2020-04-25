using System;
namespace truevalueauction.App_Code
{
    public interface IValidator
    {
        User GetUser();
        void SetUser(User user);
        void SetNewUser(bool newUser);
        bool IsValid(InputTypes input);
        bool EmailExists();
    }
}
