using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] ages =new int[5];


            ages[0] = 25;
            ages[1] = 34;
            ages[3] = 29;
            ages[2] = 21;
            ages[4] = 32;

            Array.Reverse(ages);
            // Console.WriteLine(string.Join(',',ages);
            //Console.WriteLine(Reverse( Array ages));


            // int[] array = { 2, 4, 6, 8 };
            // public static void Reverse(Array array);
            // array.reverse();
            // Console.WriteLine(String.Join(',', array));

            string[] Names = new string[] { "Ram", "Vidya", "Sachi", "Vivek", "Rani", "Shweta" };


            for(int i=0;i<Names.Length;i++)

            {
                Console.WriteLine(Names[i]);

            }



            string[] s = null;
            int? k = null;

            int j = k??0;
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
