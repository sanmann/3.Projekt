using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DBTier
{
    public class Connection
    {
        public static readonly string connectionString = @"Data Source=balder.ucn.dk;database=dm76_8;
            User id=dm76_8;Password=MaaGodt";
        public static readonly SqlConnection dbconn = new SqlConnection(connectionString);

        private static SqlCommand dbCmd;

        private static void Open()
        {
            if (dbconn.State.ToString().CompareTo("Open") != 0)
            {
                dbconn.Open();
            }
        }

        public static void Close()
        {
            dbconn.Close();
        }

        public static SqlCommand GetDBCommand(string sql)
        {
            if (dbconn.State.ToString().CompareTo("Open") != 0)
            {
                Open();
            }
            if (dbCmd == null)
            {
                dbCmd = new SqlCommand(sql, dbconn);
            }
            dbCmd.CommandText = sql;

            return dbCmd;
        }
    }
}
