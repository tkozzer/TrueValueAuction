
using System;

namespace truevalueauction.App_Code
{
    public class User
    {
        private string userName;
        private string password;
        private string firstName;
        private string lastName;
        private string email;
        private Address address;
        

        public User()
        {

        }

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

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void SetAddress(Address address)
        {
            this.address = address;
        }

       

    }

    public class Address
    {
        private string address;
        private string city;
        private string state;
        private string zipCode;

        public Address(string address, string city, string state, string zipCode)
        {
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
        }
    }
}