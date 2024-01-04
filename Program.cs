using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_LoopingStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            #region While Loop
            //int i = 1;
            //while(i <= 10){
            //    Console.Write($"{i} ");
            //    i++;
            //}
            //Console.WriteLine();
            //int j = 1;
            //while (j <= 10)
            //{
            //    Console.Write("* ");
            //    j++;
            //}

            //int k = 1;
            //while (k <= 0)
            //{
            //    Console.Write($"{k} ");
            //    k++;
            //}




            #endregion While Loop



            #region Do While Loop

            //int i = 1;
            //do
            //{
            //    Console.Write($"{i} ");
            //    i++;
            //}
            //while (i <= 10);

            //Console.WriteLine();


            //int j = 1;
            //do
            //{
            //    Console.Write($"{j} ");
            //    j++;
            //}
            //while (j <= 0);

            #endregion Do While Loop



            #region For Loop

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("* ");
            //}

            //Console.WriteLine();

            //for (int j = 1; j <= 10; j++)
            //{
            //    Console.Write(j+ " ");
            //}

            #endregion For Loop



            #region Square Pattern
            //for(int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion Square  Pattern




            #region Hollow Square Pattern
            // int n=5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (i == 1 && j <= n || j == 1 && i <= n || i==n && j<=n || j==n && i<=n)
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            #endregion Hollow Square Pattern



            #region Right Angle
            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            ////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////
            ///

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}





            #endregion Right Angle



            #region Right Angle Reverse
            //for (int i = 5; i >= 1; i--)
            //{
            //    for(int j = 1; j < i; j++)
            //    {
            //        Console.Write("  ");
            //    }

            //    for(int k = 5; k >= i; k--)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
        

        #endregion Right Angle Reverse



        #region Reverse Right Angled Triangled

        //for (int i = 5; i >= 1; i--)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(j + " ");
        //    }
        //    Console.WriteLine();
        //}


        /////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////
        ///

        //for (int i = 5; i >= 1; i--)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}

        #endregion Reverse Right Angled Triangled



        #region Plus Pattern
        //for (int i = 1; i <= 5; i++)
        //{
        //    for(int j = 1; j <= 5; j++)
        //    {
        //        if(j == 3 && i <=5   || i==3 && j <= 5)
        //        {
        //            Console.Write("* ");
        //        }
        //        else
        //        {
        //            Console.Write("  ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        #endregion Plus Pattern



        #region Random Pattern


        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = 1; j <= 5; j++)
        //    {
        //        if (j == 3 && i <= 5 || i == 3 && j <= 5 || i==2 && j==2 ||i==4 && j==4 || i==2 && j==4 || i==4 && j==2)
        //        {
        //            Console.Write("* ");
        //        }
        //        else
        //        {
        //            Console.Write("  ");
        //        }
        //    }
        //    Console.WriteLine();
        //}


        #endregion Random Pattern


        #region ButterFly Pattern


        //        //for (int i = 1; i <= 11; i++)
        //        //{
        //        //    for (int j = 1; j <= 11; j++)
        //        //    {
        //        //        if (j == 1 && i <= 11 || j == 2 && i+1 <= 10 || j == 3 && i + 2 <= 9 || j == 4 && i + 3 <= 8 || j == 5 && i + 4 <= 7 || i == 6 && j == 6
        //        //            || j == 11 && i <= 11 || j == 10 && i + 1 <= 10 || j == 9 && i + 2 <= 9 || j == 8 && i + 3 <= 8 || j == 7 && i + 4 <= 7)
        //        //        {
        //        //            Console.WriteLine("* ");
        //        //        }
        //        //        else
        //        //        {
        //        //            Console.WriteLine("  ");

        //        //        }
        //        //       // Console.WriteLine();
        //        //    }
        //    }



        //    int i, j, n = 5;
        //            for (i = 1; i <= n; i++)
        //            {
        //                for (j = 1; j <= i; j++)
        //                {
        //                    Console.Write("*");
        //                }
        //                for (j = 1; j <= (n - i); j++)
        //            {
        //                Console.Write("  ");
        //            }
        //              for (j = 1; j <= i; j++)
        //             {
        //               Console.Write("*");
        //            }
        //             Console.WriteLine();
        //                }

        //            for (i = n - 1; i >= 1; i--)
        //            {
        //    for (j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    for (j = 1; j <= (n - i); j++)
        //    {
        //        Console.Write("  ");
        //    }
        //    for (j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        //  }
        #endregion ButterFly Pattern





        Console.ReadLine();

        }
    }
}

