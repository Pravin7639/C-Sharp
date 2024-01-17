using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_stringANDstringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            //string intro = "my ";
            //intro += "name ";
            //intro += "is ";
            //intro += "khan.";

            //Console.WriteLine(intro);

            StringBuilder sb = new StringBuilder("Hi ");
            sb.Append("Good ");
            sb.Append("Morning!!");
            Console.WriteLine(sb.ToString());

            StringBuilder sb1 = new StringBuilder(50);
            //allocates maximum 50 space/length sequentially on the memory heap.
            //


            sb.Insert(8, "C# ");
            Console.WriteLine(sb.ToString());  /// Hi Good C# Morning!!


            sb.Remove(8, 12);
            Console.WriteLine(sb.ToString());

            StringBuilder sb2 = new StringBuilder("Hello Pawan, Good Morning!!");
            sb2.Replace("Pawan", "Pravin");
            Console.WriteLine(sb2.ToString());



            Console.ReadLine();
        }
    }
}
