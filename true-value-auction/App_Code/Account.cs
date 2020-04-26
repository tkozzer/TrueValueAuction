namespace truevalueauction.App_Code
{
    public class Account
    {

        private User user;

        public Account(User user)
        {
            this.user = user;
        }

        public static void CreateAccount(User user)
        {
            Database.InsertUser(user);
        }

        



    }
}