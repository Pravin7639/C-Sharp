using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ConditionalStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a First number");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a Second number");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a third number");
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine($"You entered : {first} {second} {third}");

            #region if else block

            //if (first>second)
            //{
            //    if (first > third)
            //    {
            //        Console.WriteLine($"{first} is greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}

            //else if (second > first)
            //{
            //    if (second > third)
            //    {
            //        Console.WriteLine($"{second} is greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}
            //else
            //{
            //    if (first == third)
            //    {
            //        Console.WriteLine($"{first} {second} {third} are equal");
            //    }

            //    else if (first > third)
            //    {
            //        Console.WriteLine($"{first} and {second} is greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}

            #endregion if else block

            #region ternary operator

            //int number = (first > second) ?
            //    ((first > third) ? first : third) :
            //    (second > third) ? second : third;

            //Console.WriteLine($"{number} is greater number");

            #endregion ternary operator


            //in input is divisible by 3 then print THREE
            //in input is divisible by 5 then print FIVE
            //in input is divisible by 3 and 5 then print THREEFIVE

            #region divisible by 3 & 5 

            //Console.WriteLine("Please enter a number");
            //int num = int.Parse(Console.ReadLine());

            //if(num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("THREEFIVE ");
            //}
            //else if (num % 3 == 0)
            //{
            //    Console.WriteLine(" THREE ");
            //}
            //else if (num % 5 == 0)
            //{
            //    Console.WriteLine(" FIVE ");
            //}
            //else
            //{
            //    Console.WriteLine("INVALID NUMBER");
            //}

            #endregion divisible by 3 & 5 



            #region EVEN/ODD
            //Console.WriteLine("Please enter a number");
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("EVEN");
            //}
            //else
            //{
            //    Console.WriteLine("ODD");
            //}

            //string result = (num % 2 == 0) ? "EVEN" : "ODD";

            //Console.WriteLine($"{num} is {result} number");
            #endregion EVEN/ODD


            #region GRADE
            //Console.WriteLine("Please enter a Grade");
            //char grade = char.Parse(Console.ReadLine().ToUpper());

            ////if(grade == 'A')
            ////{
            ////    Console.WriteLine($"{grade} : Distinction");
            ////}
            ////else if (grade == 'B')
            ////{
            ////    Console.WriteLine($"{grade} : First Class");
            ////}
            ////else if (grade == 'C')
            ////{
            ////    Console.WriteLine($"{grade} : Second Class");
            ////}
            ////else if (grade == 'D')
            ////{
            ////    Console.WriteLine($"{grade} : Third Class");
            ////}
            ////else if (grade == 'F')
            ////{
            ////    Console.WriteLine($"{grade} : Fail");
            ////}
            ////else
            ////{
            ////    Console.WriteLine($"{grade} : Invalid Grade");
            ////}


            //switch (grade)
            //{
            //    case 'A':
            //        Console.WriteLine($"{grade} : First Class");
            //        break;
            //    case 'B':
            //        Console.WriteLine($"{grade} : Second Class");
            //        break;
            //    case 'C':
            //        Console.WriteLine($"{grade} : Third Class");
            //        break;
            //    case 'F':
            //        Console.WriteLine($"{grade} : Fail");
            //        break;
            //    default:
            //        Console.WriteLine($"{grade} : Invalid Grade");
            //        break;
            //}


            #endregion GRADE










            Console.ReadLine();

        }
    }
}
