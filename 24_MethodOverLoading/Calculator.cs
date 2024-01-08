using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_MethodOverLoading
{
    public class Calculator
    {

        public void Print()
        {
            Console.WriteLine("PrintA() Method Called");
        }

        public void Print(int a)
        {
            Console.WriteLine($"PrintA(int a) = {a} Method called");
        }

        public void Print(int a, int b)
        {
            Console.WriteLine($"Print(int a, int b) = {a} & {b} Method Called");
        }
        public void Print(int a, int b, int c)
        {
            Console.WriteLine("Print(int a, int b, int c) Method Called");
        }

        public void Print(string str)
        {
            Console.WriteLine("Print(string str) Method Called");
        }


        public void Print(string str, string str1)
        {
            Console.WriteLine("Print(string str, string str1) Method Called");
        }

        public void Print(int a, string str)
        {
            Console.WriteLine("Print(int a, string str) Method Called");
        }

        public void Print( string str, int a)
        {
            Console.WriteLine("Print( string str, int a) Method Called");
        }

        public void Print(ref int a)
        {
            Console.WriteLine($"PrintA(ref int a) = {a} Method called");
        }
        public void Print(short num)
        {
            Console.WriteLine("Print(short num) Called");
        }
    }
}
