using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {

            Tuple<int, int, int> t1 = new Tuple<int, int, int>(11, 12, 13);

            Console.WriteLine($" {t1.Item1} : {t1.Item2} : {t1.Item3} ");

            Tuple<int, int, int, int, int, int, int> t2 =
                new Tuple<int, int, int, int, int, int, int>(21, 22, 23, 24, 25, 26, 27);

            Console.WriteLine($"{t2.Item1} : {t2.Item2} : {t2.Item3} : {t2.Item4} : " +
                $"{t2.Item5} : {t2.Item6} : {t2.Item7} ");


            Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>> t3 =
                new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>
                (31, 32, 33, 34, 35, 36, 37, t1);

            Console.WriteLine($"{t3.Item1} : {t3.Item2} : {t3.Item3} : {t3.Item4} :" +
                $" {t3.Item5} : {t3.Item6} : {t3.Item7} : {t3.Rest.Item1} : {t3.Rest.Item2} : {t3.Rest.Item3}");



            //  Tuple.Create<int, int, Tuple.Create<int, int, int>, int, int, int, int, int>
            var numbers2 =
          Tuple.Create(1, 2, Tuple.Create(11, 12, 13), 3, 4, 5);

            Console.WriteLine(numbers2.Item1);
            Console.WriteLine(numbers2.Item3.Item2);

            Console.WriteLine(numbers2.Item6);




            var result = GetDetails();
            Console.WriteLine($"{result.Item1}  :  {result.Item2}  :  {result.Item3} ");











            Console.ReadLine();
        }

        static Tuple<int, string, string> GetDetails()
        {
            Tuple<int, string, string> detail =
                new Tuple<int, string, string>(101, "Pawan", "Mumbai");

            return detail;


        }
    }
}
