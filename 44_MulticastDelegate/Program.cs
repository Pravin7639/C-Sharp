using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_MulticastDelegate
{
    class Program
    {
        public delegate string PrintDelegate();
        static void Main(string[] args)
        {

            PrintDelegate pd = PrintA;
            pd += PrintB;
            pd += PrintC;
            string result = pd();
            Console.WriteLine(result);  /// it will print last added method

            Delegate[] delegates = pd.GetInvocationList();
            // used for getting step by step proccess of pd
           // get invocation list

            for (int i = 0; i < delegates.Length; i++)
            {
                try
                {
                    var result1 = delegates[i].DynamicInvoke();
                    Console.WriteLine(result1);
                }
                catch
                {
                    Console.WriteLine("Exception Occured");
                }
            }







            Console.ReadLine();
        }

        static string PrintA()
        {
            return "PrintA()";
        }

        static string PrintB()
        {
            return "PrintB()";
        }
        static string PrintC()
        {
            return "PrintC()";
        }


    }
}
