using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_BoxingUnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine($"i  : {i} ");

            object o = i;    
            Console.WriteLine($"o  : {o} ");
            /////////////////     value type to reference type ---> Boxing............


            int j = (int)o;
            Console.WriteLine($"j  : {j}");    
            ///////////    Reference type to Value type ---> UnBoxing.............




            Console.ReadLine();
        }
    }
}
