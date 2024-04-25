using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("---Params---");
            //Console.WriteLine("Please enter Numbers");
            //int numbers = int.Parse(Console.ReadLine());

          //  Console.WriteLine("------Reverse String--------");
          //  Console.WriteLine("Please enter string to Reverse");

          //  string input = Console.ReadLine();
          //// string[] result= input.Split(new char[] {' '});
          //string[] result=  input.Split(',');

          //  for (int i =result.Length-1; i >=0; i--)
          //  {
          //      Console.Write(result[i]+" ");
          //  }

            
            //Print();
           // Print("Rama", "Waghmare");
           int r1= Add(10,25);
            Console.WriteLine(r1);

           int r2= Add1();
           int r3= Add1(24, 36);

            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.ReadLine();
        }
        public static class NestedClass
        {
            public static void Method2()
            {
            }

            public static void Method3()
            {
            }
        }
        public static void Print()
        {
            Console.WriteLine("Print()");
        }
        public static void Print(string a,string b)
        {
            Console.WriteLine($"{a} {b}");

        }
        static int Add( int a,int b)
        {
            return a + b;
        }
        static int Add1(int a=0,int b = 0)
        {
            return a + b;
        }

    }



}
