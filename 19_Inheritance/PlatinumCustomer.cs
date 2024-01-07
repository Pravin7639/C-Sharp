using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class PlatinumCustomer : Customer
    {
        public string name = "PlatinumCustomer";

        public PlatinumCustomer()
        {
            Console.WriteLine("PlatinumCustomer() constructor called");
            Console.WriteLine(this.name);
            Console.WriteLine(base.name);
            TicketAmount = 400;
        }

        public void PrintTicket()
        {
            Console.WriteLine("Platinum Ticket Printed");
        }

    }
}
