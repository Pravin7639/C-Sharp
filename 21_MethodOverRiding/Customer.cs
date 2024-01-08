using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MethodOverRiding
{
    public class Customer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(string fn, string ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }

        public virtual void Details()
        {
            Console.WriteLine($" {FirstName}  {LastName} : Normal Customer. ");
        }

    }
}
