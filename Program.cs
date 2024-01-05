using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {




            //  PrintA();

            //  PrintB("Pravin");
            //  string b = "PRAVIN";
            //  PrintB(b);

            //  PrintC("Pravin", "Mane");
            //  string f = "PRAVIN", l = "MANE";
            //  PrintC(f, l);

            //string result=  PrintD("Pravin", "Mane");
            //  Console.WriteLine($"PrintD result : FULLNAME : {result}");

            //  PrintF(true);
            //  PrintF(false);

            //  int[] nums = new int[] { 12, 12, 12, 12, 12, 12, 12 };
            //  PrintG(nums);


            Console.WriteLine("Please enter a number");
            int m = int.Parse(Console.ReadLine());

            for (int i = 2; i <= m; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + " ");

                }

            }


            Console.ReadLine();
        }

        //  //// 1... Method without return and without Parameter

        //    static void PrintA()
        //    {
        //        Console.WriteLine($"PrintA() : Method called");
        //    }


        //    ///// 2... Method without return and with Parameter

        //static void PrintB(string name)
        //    {
        //        Console.WriteLine($"PrintB() : Hello, {name}");
        //    }


        /////// 3.....Method without return and Multiple Parameter
        /////

        //    static void PrintC (string fn, string ln)
        //    {
        //        Console.WriteLine($"PrintC : Fullname : {fn} {ln} ");
        //    }




        //    ///////4.....Method with return and with Parameter


        //    static string PrintD (string fn, string ln)
        //    {
        //        return fn + " " + ln;
        //    }

        ////////// 5....Return statement in void....
        /////

        //    static void PrintF(bool isConfirmed)
        //    {
        //        if (!isConfirmed)
        //        {
        //            return;
        //        }
        //        Console.WriteLine($"PrintE ({isConfirmed}) : Seesion Allowed ");
        //    }



        //    ///////////// 6.... Sum of Array
        //    ///
        //     static void PrintG (int[] nums)
        //    {
        //        if(nums !=null && nums.Length > 0)
        //        {
        //            int sum = 0;
        //            for (int i = 0; i < nums.Length; i++)
        //            {
        //                sum += nums[i];
        //            }
        //            Console.WriteLine($" PrintG : Sum Of Array :{sum} ");
        //        }
        //        else
        //        {
        //            Console.WriteLine("No Number To Add");
        //        }
        //    }



        static bool isPrime(int n)
        {
            int count = 1;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;

            }
            else
            {
                return false;
            }
        }








    }
}
