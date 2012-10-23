using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DBTier;

namespace Database
{
    public class DbGetMax
    {
        public static int GetMax(string query)
        {
            int id = -1;
            try
            {
                SqlCommand cmd = Connection.GetDBCommand(query);
                id = (int) cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in reading max Id: " + e.Message);
            }
            return id;
        }
    }
}
