using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_isasKeyword
{

    //is & as keyword are used for type convrsion

    class Program
    {
        static void Main(string[] args)
        {
            //Customer c = new Customer(); we cannot create object of abstract class

            Customer c = new SilverCustomer();
            c.Print();

            Customer c2 = new GoldCustomer();
            c2.Print();



            SilverCustomer c3 = (SilverCustomer)c;
            c3.Print();

            // GoldCustomer c4 = (GoldCustomer)c;//runtime exception
            // c4.Print();                          


            bool b1 = c is GoldCustomer;  // is keyword tells us whether casting is possible or not
            Console.WriteLine(b1);
            if (b1)
            {
                GoldCustomer c4 = (GoldCustomer)c;
                c4.Print();
            }



            GoldCustomer c5 = c as GoldCustomer;//if typecast not possible it returns null and it does not thrown any exception
            Console.WriteLine("GoldCustomer() called");
            if (c5 != null)
            {
                c5.Print();

            }














            Console.ReadLine();
        }
    }

    public abstract class Customer
    {
        public abstract void Print();

    }

    public class SilverCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("SilverCustomer Print() Called");
        }
    }


    public class GoldCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("GoldCustomer Print() Called");
        }

    }








}


