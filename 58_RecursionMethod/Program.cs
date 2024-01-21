using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_RecursionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region factorial
            // //int num = 5;
            // //int fact = 1;
            // //for (int i = num; i > 0; i--)
            // //{
            // //    fact *= i;
            // //}
            // //Console.WriteLine($"Factorial of 5 :{fact}");

            //int fact= Factorial(5);
            // Console.WriteLine($"Factorial of 5 :{fact}");

            #endregion fact



            #region fibanacii series

            //int FirstNumber = 1;
            //int SecondNumber = 1;

            //List<int> series = new List<int>();
            //series.Add(FirstNumber);
            //series.Add(SecondNumber);

            //for (int i = 0; i < 10; i++)
            //{
            //    int ThirdNumber = FirstNumber + SecondNumber;
            //    series.Add(ThirdNumber);

            //    FirstNumber = SecondNumber;
            //    SecondNumber = ThirdNumber;
            //}

            //foreach (int item in series)
            //{
            //    Console.Write($"{item} ");
            //}



            ///////////using reccursion method/////////////

            Console.WriteLine("num= ");
            int num = int.Parse(Console.ReadLine());
            //int result = FibonacciSeries(num);
            //Console.WriteLine($"{result} ");

            Console.WriteLine("Fibonacci Series");

            for (int i = 0; i < num; i++)
            {
                Console.Write($"{FibonacciSeries(i)} ");
            }




            #endregion fibanacii series







            Console.ReadLine();
        }

        #region factorial
        static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        #endregion factorial


        #region fibanacii series

        ///////////using reccursion method/////////////

        static int FibonacciSeries(int num)
        {

            if (num <= 1)
            {
                return num;
            }
            return (FibonacciSeries(num - 1) + FibonacciSeries(num - 2));

        }



        #endregion fibanacii series





    }
}
