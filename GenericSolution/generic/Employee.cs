using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Employee :User
    {
        protected static int id = 0;
        public string Position { get; set; }
        public double Salary { get; set; }

        public int getId()
        {
            return ++id;
        }

    

    }
}
