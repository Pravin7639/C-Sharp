using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Delegates
{
    class Program
    {
        public delegate void PrintDelegate(string str);  //1st delegate declaration
        static void Main(string[] args)
        {

            ////PrintA("Vihhan");     ///methood call
            ////PrintB("Pawan");
            ////PrintC("Pravin");

            //// after writting delegate

            //PrintDelegate pd = new PrintDelegate(PrintA);  ///2nd deligate instance
            //pd("Vihaan");   //3rd delegate call

            //PrintDelegate pd1 = new PrintDelegate(PrintB);
            //pd1("Pawan");

            //PrintDelegate pd2 = new PrintDelegate(PrintC);
            //pd2("Pravin");


            //Creating Multicast Delegate

            PrintDelegate pd1 = PrintA;
            PrintDelegate pd2 = PrintB;
            PrintDelegate pd3 = PrintC;

            PrintDelegate pd = pd1 + pd2 + pd3;
            pd("Pravin");

            pd -= pd2;
            pd("Pawan");








            Console.ReadLine();
        }


        static void PrintA(string Name)
        {
            Console.WriteLine($"PrintA() Hello, {Name}");
        }

        static void PrintB(string Name)
        {
            Console.WriteLine($"PrintB() : Good Morning, {Name}");
        }

        static void PrintC(string Name)
        {
            Console.WriteLine($"PrintC() : Lovely, {Name}");
        }

        public string GetName()
        {
            return "Pravin";
        }


    }
}
