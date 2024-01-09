using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_AbstractKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer c1 = new Customer();
            // Can not create instance og ABSTRACT Class


            SilverCustomer sc = new SilverCustomer();
            sc.ShowTimings();
            sc.PrintTicket();
            Console.WriteLine("-----------------------------------------");

            GoldCustomer gc = new GoldCustomer();
            gc.ShowTimings();
            gc.PrintTicket();
            Console.WriteLine("-----------------------------------------");

            PlatiniumCustomer pc = new PlatiniumCustomer();
            pc.ShowTimings();
            pc.PrintTicket();
            Console.WriteLine("-----------------------------------------");




            Console.ReadLine();
        }
    }
}
