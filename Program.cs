using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            PrintA(a);
            Console.WriteLine(a);   ///  10

            //int m = 200;
            //PrintA(m);
            //Console.WriteLine(m);   ///   200

            /////////////////////////////////////////////////////////////////////////

            a = 10;   ////first we have to assign the value

            PrintB(ref a);
            Console.WriteLine(a);    /////   100

            ///////////////////////////////////////////////////////////////////////////////////////

            int x = 40, y = 20, add, sub, mul, div;
            PrintD(x, y, out add, out sub, out mul, out div);
            Console.WriteLine($"Addition :{x} + {y} = {x + y}");
            Console.WriteLine($"subtraction :{x} - {y} = {x - y}");
            Console.WriteLine($"Multiplication :{x} * {y} = {x * y}");
            Console.WriteLine($"Devision :{x} / {y} = {x / y}");

            Console.WriteLine();

            ///////////////////////////////////////////////////////////////////////////////////////
            ///

            int[] nums = { 10, 20, 30 };
            Print(nums);
            Print(new int[] { 10, 20, 30 });
            Print(10, 20, 30);

            Console.WriteLine();


            int[] num = null;
            Print(num);
            Print(null);
            Print();

            Console.ReadLine();
        }












        //Pass By Value

        static void PrintA(int a)
        {
            a = 100;
        }

        //Ref KeyWord

        static void PrintB(ref int a)
        {
            ///a = 100;    /// it should work in this condition also but value should printed which is assigned in the Main Method
            a = 100;
        }

        static void PrintD(int a, int b, out int add, out int sub, out int mul, out int div)
        {
            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
        }



        static void Print(params int[] numbers)
        {
            if (numbers != null && numbers.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"Sum of Array : {sum}");
            }
            else
            {
                Console.WriteLine("EMPTY ARRAY");
            }

        }








    }
}
