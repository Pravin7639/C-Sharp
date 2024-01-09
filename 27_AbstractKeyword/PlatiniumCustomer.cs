using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_AbstractKeyword
{
    class PlatiniumCustomer : Customer
    {
        public override void PrintTicket()
        {
            Console.WriteLine("Platinium Customer() Ticket Printed ");  
        }
    }
}
