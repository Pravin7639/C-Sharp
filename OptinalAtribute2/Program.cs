using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OptinalAtribute2
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();

            PrintDel a1 = d1.PrintA;
            a1 += d1.PrintB;
            a1 += d1.PrintC;
            a1();//delegate call
           // Delegate[] s1 = a1.getinvocationlist();

            // Console.WriteLine(a1);

            PrintA a2 = d1.PrintX;
            a2 += d1.PrintY;
            a2 += d1.PrintZ;
            Delegate[] s2 = a2.GetInvocationList();
            for (int i = 0; i < s2.Length; i++)
            {
                var val = s2[i].DynamicInvoke();
                Console.WriteLine(val);
            }
           // Console.WriteLine(a2);
            //A a1 = new A();
            ////  a1.Id = 10;


            //// a1.Print();

            //float a = 10.5F;
            //int b = (int)a;
            //Console.WriteLine("Please enter Number:-");
            //var a1 = Console.ReadLine();
            //string v1 = "Sam";

            //// int a2 = (int)a1;
            //Console.WriteLine(b);
            Console.ReadLine();
        }
        public static void Add([OptionalAttribute] int a, [OptionalAttribute] int b)
        {

            Console.WriteLine(a + b);
        }
    }
      public delegate void PrintDel();
    public delegate string PrintA();
    class Demo
    {

        public void PrintA() { Console.WriteLine("A"); }

        public void PrintB() { Console.WriteLine("B"); }

        public void PrintC() { Console.WriteLine("C"); }
        public string PrintX() {
            return "printX";
        }
        public string PrintY() {
            return "printY";
        }
        public string PrintZ() {
            return "printZ";
        }



    }
//    public class A
//    {

//        private int Id;
//        protected void Print()
//        {
//            Console.WriteLine("Print()");
//        }

//    }
//    public class B : A
//    {
//        public void PrintB()
//        {
//            Print();

//        }
//    }
//   internal class C {

//        internal void PrintC() { Console.WriteLine("PrintC"); }
//    }
//    internal class D
//    {
//        internal void PrintD()
//        {
//            C c1 = new C();
//           c1.PrintC();

//        }

//    }
}
