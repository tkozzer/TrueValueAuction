
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

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetEmail()
        {
            return email;
        }

        public Address GetAddress()
        {
            return address;
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
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string zipCode;

        public Address(string address1, string address2, string city, string state, string zipCode)
        {
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
        }

        public string GetAddress1()
        {
            return address1;
        }

        public string GetAddress2()
        {
            return address2;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetState()
        {
            return state;
        }

        public string getZipCode()
        {
            return zipCode;
        }
    }
}