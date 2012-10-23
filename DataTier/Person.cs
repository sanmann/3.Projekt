using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTier
{
    public class Person
    {
        private int id;
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private string phoneNumber;
        private string email;
        private int postalCode;
        private City city;
        private UserCredentials userCredentials;

        public Person(string firstName, string middleName, string lastName, string address, string phoneNumber, string email, int postalCode, UserCredentials userCredentials)
        {
            id = 0;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.postalCode = postalCode;
            this.userCredentials = userCredentials;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
