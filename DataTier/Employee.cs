using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTier
{
    public class Employee : Person
    {
        private int id;
        private int cpr;

        public Employee(int cpr, string firstName, string middleName, string lastName, string address, string phoneNumber, string email, int postalCode, UserCredentials userCredentials)
            : base(firstName, middleName, lastName, address, phoneNumber, email, postalCode, userCredentials)
        {
            id = 0;
            this.cpr = cpr;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int CPR
        {
            get { return cpr; }
            set { cpr = value; }
        }
    }
}
