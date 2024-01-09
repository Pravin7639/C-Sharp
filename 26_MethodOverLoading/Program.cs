using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_MethodOverLoadingScenario
{

    /// METHOD OVERLOADING USING MULTIPLE CLASS
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.PrintA();

            B b = new B();
            b.PrintA(10);
            b.PrintA();


            Console.ReadLine();
        }
    }

    public class A
    {
        public void PrintA()
        {
            Console.WriteLine("A : PrintA()");

        }
    }

    public class B : A
    {
        public void PrintA(int a)
        {
            Console.WriteLine("B : PrintA(int a)");
        }

    }




}
