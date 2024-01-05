using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {

            #region multiDiamentional Array
            ///MultiDiamentional Array


            int[,] num = new int[3, 3];
            //int[][] num = new int[3][3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{i}{j} ");
                }
                Console.WriteLine();
            }
            #endregion multiDiamentional Array




            #region get corner elements
            // to get corner elements of multidiamentional array

            int[,] n = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j || j <= i)
                    {
                        Console.Write($"{i}{j} ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            #endregion get corner elements



            #region max number
            //find maximum element of an array
            int[] num1 = new int[] { 5, 10, 3, 8, 15 };

            int max = num1[0];
            for (int i = 0; i < num1.Length; i++)
            {

                if (num1[i] > max)
                {
                    max = num1[i];
                }

            }
            Console.WriteLine(max);

            #endregion max number



            #region sum of array

            //sum of given array

            int[] num2 = new int[] { 5, 10, 3, 8, 15 };
            int sum = 0;
            for (int i = 0; i < num2.Length; i++)
            {
                sum += num2[i];
            }
            Console.WriteLine(sum);

            #endregion sum of array



            #region reverse of array
            ////reverse of array

            //int[] num = new int[] { 5, 10, 3, 8, 15 };
            ////////Array.Reverse(num);
            ////////Console.WriteLine(string.Join(", ",num));

            string[] num3 = new string[] { "Pravin", "Pawan", "Ram", "Ravan" };


            for (int i = num3.Length - 1; i >= 0; i--)
            {
                Console.Write(num3[i] + ", ");
            }

            #endregion rreverse of array 



            #region Finding Average Number
            //Find Average Element Of Array

            int[] num4 = new int[] { 5, 10, 3, 8, 15 };

            ////double avg = num.Average();
            ////Console.WriteLine(avg);

            double sum1 = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum1 += num4[i];
            }
            double avg = sum1 / (num.Length);

            Console.WriteLine(sum1);
            Console.WriteLine(avg);


            #endregion



            #region Search For Value
            //Search For An Element

            int[] num5 = new int[] { 5, 10, 8, 3, 15 };

            for (int i = 0; i < num5.Length; i++)
            {
                if (num5[i] == 8)
                {
                    Console.WriteLine("Cought");
                    break;
                }

            }

            #endregion Search For Value



            #region Remove Element From Array
           // Remove Element From Array
            int[] num6 = new int[] { 5, 10, 8, 3, 15 };

            for (int i = 0; i < num6.Length; i++)
            {
                if (num6[i] == 8)
                {
                    continue;

                }
                else
                {
                    Console.Write(num6[i] + ", ");
                }
            }

            #endregion Remove Element From Array



            #region Count Occurence Of Element
            ////Count Occurence Of Element

            int[] num7 = new int[] { 1, 2, 3, 4, 5, 1, 2, 2, 2, 2, 2, 3 };

            int count = 0;
            for (int i = 0; i < num7.Length; i++)
            {

                if (num7[i] == 2)
                {
                    count++;

                }
                else
                {
                    continue;
                }

            }

            Console.WriteLine($"Occurence of Number 2 is : {count}");

            #endregion Count Occurence Of Element



            ////Remove Duplicate Elements

            int[] num8 = new int[] { 5, 10, 8, 3, 15, 5, 3 };

            int count1 = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num8[i] == num8[j])
                    {
                        count1++;
                    }

                }
                if (count1 == 1)
                {
                    Console.Write(num8[i] + " ");
                }

            }



            #region Fibonacci series

            int n1 = 0, n2 = 1;
            Console.WriteLine("Please enter a number");
            int num9 = int.Parse(Console.ReadLine());
            Console.Write(n2 + " " + n2 + " ");

            for (int i = 2; i < num9; i++)
            {
                int n3 = n1 + n2;
                Console.Write(n3 + " ");

                n1 = n2;
                n2 = n3;
            }




            #endregion Fibonacci series










            #region Printing Particular element INDEX

            //Printing Particular element INDEX

            int[] num10 = new int[] { 5, 10, 8, 3, 15 };

            for (int i = 0; i < num10.Length; i++)
            {
                if (num10[i] == 5)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion Printing Particular element INDEX



            Console.ReadLine();
        }
    }
}
