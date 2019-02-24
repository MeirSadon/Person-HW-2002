﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2002
{
    class PersonCompareByHeight : IComparer<Person>
    {
            public int Compare(Person x, Person y)
            {
                return Convert.ToInt32(x.Height - y.Height);
            }
    }
}
