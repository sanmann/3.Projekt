using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataTier;
using System.Data.SqlClient;

namespace DBTier
{
    public class DBEmployee
    {
        private SqlCommand cmd = null;

        public Employee GetEmployeeByEmployeeID(int EmployeeID)
        {
            string sql = @"SELECT * from Employee WHERE @EmployeeID = " + EmployeeID;
            return BuildEmployee(sql);
        }
        private Employee BuildEmployee(string sql)
        {
            IDataReader dbReader;
            Employee employee = null;

            try
            {
                cmd = Connection.GetDBCommand(sql);
                dbReader = cmd.ExecuteReader();
                if (dbReader.Read())
                {
                    employee = new Employee((int)dbReader["CPR"]);
                    employee.Id = (int)dbReader["CustomerId"];
                }
                Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Find Employee failed!" + e.Message);
                employee = null;
            }
            return employee;
        }
    }
}
