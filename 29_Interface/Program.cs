using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer2 c = new SilverCustomer();
            c.ShowTmings();
            c.PrintTicket();

            c = new GoldCustomer();
            c.ShowTmings();
            c.PrintTicket();

            SilverCustomer sc = new SilverCustomer();
            sc.ShowTmings();
            sc.PrintTicket();

            GoldCustomer gc = new GoldCustomer();
            gc.ShowTmings();
            gc.PrintTicket();

            Console.WriteLine("-----------------------------------------");

            A a = new A();
            a.PrintA();
            a.PrintB();
            ((IA)a).Print();
            ((IB)a).Print();

            IA ia = new A();
            ia.Print();
            ia.PrintA();


            IB ib = new A();
            ib.Print();
            ib.PrintB();







            Console.ReadLine();
        }
    }
}
