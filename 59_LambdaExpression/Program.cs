using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Using Separate Method
            //Calculator c1 = new Calculator();
            //Predicate<int> del1 = c1.Even;
            //bool b1 = del1(10);
            //Console.WriteLine(b1);

            //b1 = del1(11);
            //Console.WriteLine(b1);
            #endregion Using Separate Method



            #region Using Anonymous Method

            //Predicate<int> del1 = delegate (int num)
            //  {
            //      return num % 2 == 0;
            //  };

            //Console.WriteLine(del1(10));
            //Console.WriteLine(del1(11));


            #endregion Using Anonymous Method








            Console.ReadLine();
        }

        //static bool Even(int num)
        //{
        //    return num % 2 == 0;
        //}

    }

    public class Calculator
    {
        public bool Even(int num)
        {
            return num % 2 == 0;
        }
    }
}
