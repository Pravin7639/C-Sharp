using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_MethodOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Print();

            c.Print(10);

            c.Print(10, 10);

            c.Print(10, 10, 10);

            c.Print("Pawan");

            c.Print("Pravin", "Mane");

            c.Print(45, "Pawan");

            c.Print("Pawan", 45);

            int i = 200;
            c.Print(ref i);

            c.Print(23);  // it call int method

            short k= 5000;
            c.Print(k);


            Console.ReadLine();
        }
    }
}
