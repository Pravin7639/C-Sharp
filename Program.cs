using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _14_OptionalMethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {

            add(10, 20);

            //default value

            add1(10);

            add2();


            add3(10, 20);
            add3(10);


            add4(10, 20);
            add4();





            Console.ReadLine();
        }


        static void add(int a, int b)
        {
            Console.WriteLine($"Addition : {a} + {b} = {a + b}");
        }



        /// Giving default value 
        /// always give default value to last parameter
        /// 
        static void add1(int a, int b = 5)
        {
            Console.WriteLine($"Addition : {a} + {b} = {a + b}");

        }


        static void add2(int a = 10, int b = 20)
        {
            Console.WriteLine($"Addition : {a} + {b} ={a + b}");
        }



        /// using optional Parameter
        static void add3(int a, [Optional] int b)
        {
            Console.WriteLine($"Addition : {a} + {b} ={a + b} ");
        }


        static void add4([Optional] int a, [Optional] int b)
        {
            Console.WriteLine($"Addition : {a} + {b} ={a + b}");
        }


    }
}
