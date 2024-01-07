using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class Customer
    {

        public int TicketAmount;
        public string name = "Customer";

        public Customer()
        {
            Console.WriteLine("Customer() constructor called");
        }

        public void ShowsTiming()
        {
            Console.WriteLine("** ALL TODAYS SHOWS **");
        }

        public void GetTicketAmount()
        {
            Console.WriteLine($"Ticket Amount is : {TicketAmount}");
        }




    }
}
