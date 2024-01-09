using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_AbstractKeyword
{
    public abstract class Customer
    {
        public Customer()
        {
            Console.WriteLine("Customer() Constructor Called");
        }

        public void ShowTimings()
        {
            Console.WriteLine("** ALL TODAYS SHOWS **");
        }


        public abstract void PrintTicket();  // Abstract Method
        //Abstract method can be written inside the abstract class

    }
}
