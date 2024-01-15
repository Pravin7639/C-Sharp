using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_GenericDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Predicate Delecate

            // // //public delegate bool Predicate<in T>(T obj);
            // // // it requires method which return bool type value

            // Predicate<int> p1 = Method1;
            //bool b1= p1(5);
            // Console.WriteLine(b1);

            // b1 = p1(20);
            // Console.WriteLine(b1);

            // Predicate<string> p2 = Method2;
            // b1 = p2("Pawan");
            // Console.WriteLine(b1);

            // b1 = p2("Pravin");
            // Console.WriteLine(b1);




            #endregion Predicate Delecate


            #region Action Delegate

            ////// public delegate void Action<in T>(T obj);

            //Action<string> a1 = Print1;
            //a1("Pravin");

            //Action<string, string, int> a2 = Print2;
            //a2("Pawan", "Mane", 45);

            //Action a3 = Print3;
            //a3();


            #endregion Action Delegate



            #region Func Delegate

            //////public delegate TResult Func<out TResult>();
            //////public delegate TResult Func<in T, out TResult>(T arg);


            //Func<string, int> f1 = PrintA;
            //int b1 = f1("Pawan");
            //Console.WriteLine(b1);

            //b1 = f1("PawanKalyan");
            //Console.WriteLine(b1);


            //Func<int, int, int> f2 = Add;
            //int b2 = f2(100, 100);
            //Console.WriteLine(b2);

            //b2 = f2(500, 500);
            //Console.WriteLine(b2);




            #endregion Func Delegate


            #region Anonymous Method

            Predicate<int> p1 = delegate (int i)
            {
                return i % 2 == 0 ? true : false;
            };
            bool b1 = p1(29);
            Console.WriteLine(b1);
            b1 = p1(29);
            Console.WriteLine(b1);


            Predicate<string> p2 = delegate (string s)
              {
                  return s.Length > 3 ? true : false;
              };
            b1 = p2("Raj");
            Console.WriteLine(b1);
            b1 = p2("RaviKumar");
            Console.WriteLine(b1);


            Console.WriteLine("-------------------------------------");


            Action<string> p3 = delegate (string s)
            {
                Console.WriteLine($"{s}");
            };
            p3("Pawan");


            Action<string, string> p4 = delegate (string s1, string s5)
              {
                  Console.WriteLine($"{s1}  {s5}");
              };
            p4("Pravin", "Mane");


            Action p5 = delegate ()
            {
                Console.WriteLine("Anonymous Method");
            };
            p5();


            Console.WriteLine("---------------------------------------");


            Func<string, string> p6 = delegate (string s1)
            {
                return s1;
            };
            string s2 = p6("PAWAN");
            Console.WriteLine(s2);

            Func<int, int, int> p7 = delegate (int a, int b)
             {
                 return a + b;
             };
            int c = p7(25, 25);
            Console.WriteLine(c);



            //Func<string, string, string> d4 = (s1, s2) => s1 + " " + s2;           


            #endregion Anonymous Method







            Console.ReadLine();
        }

        static bool Method1(int i)
        {
            return i % 2 == 0 ? true : false;
        }

        static bool Method2(string str)
        {
            return str.Length > 5 ? true : false;
        }

        //////////////////////////////////////////////////////////
        static void Print1(string str)
        {
            Console.WriteLine($"length of string : {str.Length}");
        }

        static void Print2(string str1, string str2, int i)
        {
            Console.WriteLine($"Given Values Are : {str1} : {str2} : {i}");
        }

        static void Print3()
        {
            Console.WriteLine("Print3() Method Called");
        }

        //////////////////////////////////////////////////////////////

        static int PrintA(string s)
        {
            return s.Length;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }







    }
}
