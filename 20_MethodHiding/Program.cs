using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MethodHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print();
            c1.PrintA();


            Console.WriteLine("--------------------------------------------");

            SilverCustomer sc = new SilverCustomer();
            sc.Print();
            sc.PrintA();
            sc.PrintB();





            Console.ReadLine();
        }
    }
}
