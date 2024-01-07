using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class GoldCustomer : Customer
    {
        //  public int TicketAmount;
        public string name = "GoldCustomer";


        public GoldCustomer()
        {

            Console.WriteLine("GoldCustomer() constructor called");
            Console.WriteLine(this.name);
            Console.WriteLine(base.name);
            TicketAmount = 250;
        }

        //public void ShowsTiming()
        //{
        //    Console.WriteLine("** ALL TODAYS SHOWS **");
        //}



        //public void GetTicketAmount()
        //{
        //    Console.WriteLine($"Ticket Amount is : {TicketAmount}");
        //}

        public void PrintTicket()
        {
            Console.WriteLine("Gold Ticket Printed");
        }
    }
}
