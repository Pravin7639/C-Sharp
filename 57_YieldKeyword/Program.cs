using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_YieldKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = 
                new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            foreach (int num in GetEven(numbers))
            {
                Console.Write($"{num} ");
            }



            Console.ReadLine();
        }



        static IEnumerable<int> GetEven(List<int> nums)
        {
            // List<int> temp = new List<int>();

            foreach (int num1 in nums)
            {
                if (num1 % 2 == 0)
                {
                    //    temp.Add(num);
                    yield return num1;
                }
            }
            // return temp;


        }


    }
}
