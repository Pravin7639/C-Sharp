using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class SilverCustomer : Customer
    {
        //   public int TicketAmount;     // fields

        public string name = "SilverCustomer";     // fields


        public SilverCustomer()           //  constructor 
        {
            Console.WriteLine("SilverCustomer() constructor called");
            Console.WriteLine(this.name);
            Console.WriteLine(base.name);

            TicketAmount = 150;
        }

        //public void ShowsTimings()          //   Method
        //{
        //    Console.WriteLine("** ALL TODAYS SHOWS **");
        //}



        //public void GetTicketAmount()    // Method
        //{
        //    Console.WriteLine($"Ticket Amount is : {TicketAmount}");
        //}


        public void PrintTicket()       //  Method
        {
            Console.WriteLine("Silver Ticket Printed");
        }


    }
}
