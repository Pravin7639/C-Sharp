using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer();
            c1.ShowsTiming();
            c1.GetTicketAmount();
            Console.WriteLine("-----------------------------------------");

            SilverCustomer sc1 = new SilverCustomer();
            sc1.ShowsTiming();
            sc1.GetTicketAmount();
            sc1.PrintTicket();

            Console.WriteLine("-----------------------------------------");



            GoldCustomer gc1 = new GoldCustomer();
            gc1.ShowsTiming();
            gc1.GetTicketAmount();
            gc1.PrintTicket();

            Console.WriteLine("-----------------------------------------");



            PlatinumCustomer pc1 = new PlatinumCustomer();
            pc1.ShowsTiming();
            pc1.GetTicketAmount();
            pc1.PrintTicket();

            Console.WriteLine("-----------------------------------------");
















            Console.ReadLine();
        }
    }
}
