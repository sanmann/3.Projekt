﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTier
{
    public class Employee
    {
            private int id;
            private int cpr;

            public Employee(int cpr)
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
