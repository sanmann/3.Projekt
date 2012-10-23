using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTier
{
    public class City
    {
        private int id;
        private int postalCode;
        private string cityName;

        public City(int postalCode, string cityName)
        {
            id = 0;
            this.postalCode = postalCode;
            this.cityName = cityName;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
    }
}
