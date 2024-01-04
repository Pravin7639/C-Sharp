using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Array
{
    class Program
    {
        static void Main(string[] args)
        {



            int[] fees = new int[3];
            fees[0] = 20000;
            fees[1] = 15000;
            fees[2] = 25000;
            for (int i = 0; i < fees.Length; i++)
            {
                Console.Write($"Number of Items : {fees[i]} ");
            }

            Console.WriteLine();

            string[] name = new string[] { "Pravin", "Pawan", "Ram", "Ravan" };

            Console.Write($"Length of string :{name.Length}");

            for (int j = 0; j < name.Length; j++)
            {
                Console.WriteLine($"names : {name[j]}");
            }


            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };





            ///////////////////Creating Array Of Empty 
            ///

            string[] email = null;
            email = new string[] { " p@p.com", "args@a.com", "k@k.com", "m@m.com", "s@s.com" };

            Console.WriteLine(email.Length);



            //////////////////// Reversing Array
            ///

            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("orignal array");

            for (int k = num.Length - 1; k >= 0; k--)
            {
                Console.Write(num[k] + " ");
            }


            Console.WriteLine();

            ////////////find highest numbe from array
            ///

            int[] n = new int[] { 12, 21, 32, 23, 43, 34, 45, 45, 56, 67, 99 };

            int max = n[0];
            for (int l = 0; l < n.Length; l++)
            {
                if (max < n[l])
                {
                    max = n[l];
                }

            }
            Console.WriteLine(max);




            ///////////////////// Reverse Input String 
            ///

            Console.WriteLine("Please enter a name");
            string nam = Console.ReadLine();

            string reverse = string.Empty;

            for (int o = nam.Length - 1; o >= 0; o--)
            {
                reverse += nam[o];
            }

            Console.WriteLine(reverse);



            //////////////////////// Reverse Words IN Sentence
            ///

            Console.WriteLine("Please Enter A Sentence");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ' });

            Console.WriteLine("output : ");

            for (int p = words.Length - 1; p >= 0; p--)
            {
                Console.Write($"{words[p]} ");
            }

            Console.WriteLine();

            ////////////////////////////////Reversing Sentence
            ///

            Console.WriteLine("Please Enter A Sentence");
            string sentences = Console.ReadLine();

            string ReversedSentences = string.Empty;
            for (int q = sentences.Length - 1; q >= 0; q--)
            {
                ReversedSentences += sentences[q];

            }

            Console.WriteLine(ReversedSentences);



            //////// sorting of array
            ///



            string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "BMW", "Volvo" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }










            Console.ReadLine();
        }
    }
}
