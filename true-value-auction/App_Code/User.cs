
namespace truevalueauction.App_Code
{
    public class User
    {
        private string userName;
        private string password;

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public string GetUserName()
        {
            return userName;
        }

        public string GetPassword()
        {
            return password;
        }
    }
}