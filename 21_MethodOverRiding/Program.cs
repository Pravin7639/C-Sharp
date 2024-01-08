using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MethodOverRiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Pravin", "Mane");
            c1.Details();

            Customer c2 = new SiverCustomer("Pawan", "Mane");
            c2.Details();

            Customer c3 = new GoldCustomer("Sachin", "Mane");
            c3.Details();


            SiverCustomer sc = new SiverCustomer("Vihaan", "Raut");
            sc.Details();

            GoldCustomer gc = new GoldCustomer("Aryan", "Raut");
            gc.Details();







            Console.ReadLine();
        }
    }
}
