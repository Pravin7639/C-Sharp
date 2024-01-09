using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_AbstractKeyword
{
    class GoldCustomer : Customer
    {
        public override void PrintTicket()
        {
            Console.WriteLine("Gold Customer() Ticket Printed ");
        }
    }
}
