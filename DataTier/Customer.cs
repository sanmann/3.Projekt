using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTier
{
    public class Customer : Person
    {
        private int id;
        private int customerNumber;

        public Customer(int customerNumber, string firstName, string middleName, string lastName, string address, string phoneNumber, string email, int postalCode, UserCredentials userCredentials)
            : base(firstName, middleName, lastName, address, phoneNumber, email, postalCode, userCredentials)
        {
            id = 0;
            this.customerNumber = customerNumber;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int CustomerNumber
        {
            get { return customerNumber; }
            set { customerNumber = value; }
        }
    }
}
