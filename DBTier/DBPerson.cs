using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataTier;

namespace DBTier
{
    public class DBPerson
    {
        private SqlCommand cmd = null;

        public Person GetPersonByPersonID(int PersonID)
        {
            string sql = @"SELECT * from Person WHERE @PersonID = " + PersonID;
            return BuildPerson(sql);
        }
        private Person BuildPerson(string sql)
        {
            IDataReader dbReader;
            Person person = null;

            try
            {
                cmd = Connection.GetDBCommand(sql);
                dbReader = cmd.ExecuteReader();
                if (dbReader.Read())
                {
                    person = new Person((int)dbReader["CustomerNumber"]);
                    person.Id = (int)dbReader["PersonID"];
                }
                Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Find Customer failed!" + e.Message);
                person = null;
            }
            return person;
        }
    }
}
