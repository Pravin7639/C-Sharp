using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MethodHiding
{
   public class Customer
    {
        public void Print()
        {
            Console.WriteLine("Customer Print() Method Called");
        }

        public void PrintA()
        {
            Console.WriteLine("Customer PrintA() Method Called");
        }
    }

    public class SilverCustomer : Customer
    {

        //using NEW keyword we can hide the method

        new public void Print()
        {
            Console.WriteLine("Silver Customer Print() Method Called");
        }

        public void PrintB()
        {
            Console.WriteLine("Silver Customer Print() Method Called");
        }

    }

}
