using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataTier;

namespace DBTier
{
    public class DBCustomer
    {
        private SqlCommand cmd = null;

        public Customer GetCustomerByCustomerID(int CustomerID)
        {
            string sql = @"SELECT * from Employee WHERE @EmployeeID = " + CustomerID;
            return BuildCustomer(sql);
        }
        private Customer BuildCustomer(string sql)
        {
            IDataReader dbReader;
            Customer customer = null;

            try
            {
                cmd = Connection.GetDBCommand(sql);
                dbReader = cmd.ExecuteReader();
                if (dbReader.Read())
                {
                    customer = new Customer((int)dbReader["CustomerNumber"]);
                    customer.Id = (int)dbReader["CustomerID"];
                }
                Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Find Customer failed!" + e.Message);
                customer = null;
            }
            return customer;
        }
    }
}
