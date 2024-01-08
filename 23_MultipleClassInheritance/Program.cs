using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_MultipleClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Print();

            A a1 = new B();
            a1.Print();

            A a2 = new C();
            a2.Print();


            B b = new B();
            b.Print();


            C c = new C();
            c.Print();





            Console.ReadLine();
        }
    }
}
