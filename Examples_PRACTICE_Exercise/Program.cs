using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_PRACTICE_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1 coffee shop
            ///// Write a program for coffee shop.
            ////  display menu to user -
            ////  Please choose coffee size
            ////  1 - Small 2 - Medium 3 - Large
            ////  Total bill amount -

            //Console.WriteLine("Please enter your cofee order  1 - Small 2 - Medium 3 - Large ");
            //int order = int.Parse(Console.ReadLine());
            //int Price = 0;

            //switch (order)
            //{
            //    case 1:
            //        Console.WriteLine("Your order of Small cofee is confirmed");
            //        Price = 10;
            //        break;
            //    case 2:
            //        Console.WriteLine("Your order of Medium cofee is confirmed");
            //        Price = 20;
            //        break;
            //    case 3:
            //        Console.WriteLine("Your order of Large cofee is confirmed");
            //        Price = 30;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Order");
            //        break;
            //}
            //Console.WriteLine($"Your Total bill amount is : {Price}");


            #endregion coffee shop



            #region coffee shop

            //int Price = 0;
            //string response;
            //bool OrderAgain = true;

            //while (OrderAgain)
            //{

            //    Console.WriteLine("Please enter your cofee order 1-Small, 2-Medium, 3-Large ");
            //    int num = int.Parse(Console.ReadLine());


            //   
            //    if (num == 1)
            //    {
            //        Console.WriteLine("Your order of Small Coffee is confirmed ");
            //        Price = 10;
            //    }
            //    else if (num == 2)
            //    {
            //        Console.WriteLine("Your order of Medium Coffee is confirmed");
            //        Price = 20;
            //    }
            //    else if (num == 3)
            //    {
            //        Console.WriteLine("Your order of Large Coffee is confirmed");
            //        Price = 30;
            //    }
            //    else
            //    {
            //        Console.WriteLine("INVALID INPUT");
            //    }

            //    Console.WriteLine($"Your total bill amount is : {Price}");



            //    Console.WriteLine("Would you like to order again or anything else Y/N");
            //    response = Console.ReadLine();
            //    response = response.ToUpper();

            //    if (response == "Y")
            //    {
            //        OrderAgain = true;
            //    }
            //    else
            //    {
            //        OrderAgain = false;
            //    }


            //}

            //Console.WriteLine("Thank you for visiting.....Visit Again...");

            #endregion coffe shop




            #region 2 Prime Number

            ////Write a program to find whether the given input is prime or not.

            //Console.WriteLine("Please enter a number");
            //int num = int.Parse(Console.ReadLine());

            //int count = 1;
            //for (int i = 2; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        count++;
            //    }

            //}

            //if (count == 2)
            //{
            //    Console.WriteLine($"{num} is a Prime Number");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is a not Prime Number");

            //}

            #endregion Prime Number




            #region 3 prime numbers till target.

            ///// Write a program to print all prime numbers till target. 
            /////(take target from user)

            //Console.WriteLine("Please enter a target number");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.Write(i + " ");
            //    }

            //}

            #endregion prime numbers till target.




            #region 4 fibonacci series
            //// Write a program to print fibonacci series.


            //int n1 = 0, n2 = 1;
            //Console.WriteLine("Please enter a target Number");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write(n1 + " " + n2 + " ");

            //for (int i = 2; i < num; i++)
            //{
            //    int n3 = n1 + n2;
            //    Console.Write(n3 + " ");


            //    n1 = n2;
            //    n2 = n3;

            //}


            #endregion fibonacci series




            #region 5 string is palindrome

            /////Write a program to find if a given string is palindrome.

            //Console.WriteLine("Please enter a String");
            //string s = Console.ReadLine();
            // s= s.ToUpper();
            //string s1 ="";

            //for (int i = s.Length-1; i >= 0; i--)
            //{
            //    s1 += s[i];
            //}

            //if (s == s1)
            //{
            //    Console.WriteLine("String is Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("String is Not Palindrome");
            //}

            #endregion string is palindrome



            /// 6 Write a program to find if a given number is armstrong.





            #region 7 Write a program to reverse a string. (without using reverse method)

            ////Write a program to reverse a string. (without using reverse method)

            //Console.WriteLine("Please enter a string ");
            //string str = Console.ReadLine();

            //for (int i = str.Length-1; i >=0; i--)
            //{
            //    Console.Write(str[i]+" ");
            //}


            #endregion 7 Write a program to reverse a string. (without using reverse method)



            #region 8. Write a program to reverse given array.
            ////8. Write a program to reverse given array.

            //int[] num = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            //for (int i = num.Length-1; i >=0; i--)
            //{
            //    Console.Write(num[i]+" ");
            //}


            #endregion 8. Write a program to reverse given array.



            #region 9 if else if block

            ////      //9.Write a program which take input from user -
            ////   print 'THREE' if that number is divisbile by 3.
            ////   print 'FIVE' if that number is divisbile by 5.
            ////   print 'THREEFIVE' if that number is divisbile by 3 & 5 both.


            //Console.WriteLine("Please enter a number");
            //int num = int.Parse(Console.ReadLine());

            //if(num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("THREEFIVE");

            //}else if (num % 3 == 0)
            //{
            //    Console.WriteLine("THREE");
            //}
            //else if (num % 5 == 0) 
            //        {
            //    Console.WriteLine("FIVE");
            //}
            //else
            //{
            //    Console.WriteLine("INVALID NUMBER");
            //}
            #endregion 9 if else if block



            //10.Write a program to print below series: 
            // (easy with 2 for loops but try with single for loop)
            //        if input is 4 -
            //        o / p - 1 3 2 4
            //    if input is 5
            //   o / p - 1 3 5 2 4



















            #region 11  Write a program to sort a array using bubble sort

            //// 11  Write a program to sort a array using bubble sort.


            //int[] arr = new int[] { 9, 2, 8, 3, 7, 4, 6, 5, 1 };


            //BubbleSort(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            #endregion  11  Write a program to sort a array using bubble sort







            #region 12 Swap two numbers without using third variable. 

            //  // Swap two numbers without using third variable.

            //  int i = 10, j = 20;
            //  Console.WriteLine(i);
            //  Console.WriteLine(j);

            //  j = j - i;
            //  Console.WriteLine(j);

            //  i = i + j;
            ////  i = i - j;
            //  Console.WriteLine(i);


            #endregion Swap two numbers without using third variable.






            #region 13 Swap two numbers using third temporary variable.

            //// Swap two numbers using third temporary variable.


            //int a = 10, b = 20, c;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //c = b - a;
            //Console.WriteLine(c);

            //a = a + c;
            //Console.WriteLine(a);


            #endregion Swap two numbers using third temporary variable.







            //// 14.Print fibonacci series using recursion.











            #region 15. Write a program to find highest number from array.
            ////15. Write a program to find highest number from array.

            //int[] num = new int[] { 10, 20, 30, 40, 50, 60, 80, 70, 50, 90, 66, 565, 5, 45, 10 };

            //int max = num[0];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] > max)
            //    {
            //        max = num[i];
            //    }
            //}
            //Console.WriteLine($"Highest number of an array is : {max} ");



            #endregion 15. Write a program to find highest number from array.




            // 16  a program to find second highest number from array.
            //(This program should be able to change for nth highest number)






            #region 17. Write a program to find pairs from array whose sum is equal to 30.


            //// 17. Write a program to find pairs from array whose sum is equal to 30.



            //   int[] num = new int[] { 10, 5, 20, 15, 25, 30,0 };

            //   FindPairsWithSum(num, 30);


            #endregion 17. Write a program to find pairs from array whose sum is equal to 30.














            Console.ReadLine();
        }
















        #region 3 prime numbers till target.


        //public static bool IsPrime(int k)
        //{
        //    int count = 0;
        //    for (int i = 1; i <= k; i++)
        //    {
        //        if (k % i == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    if (count == 2)
        //    {
        //        return true;

        //    }
        //    else
        //    {
        //        return false;
        //    }

        //  }
        #endregion prime numbers till target.


        #region 11 bubble sort


        //public static void BubbleSort(int[] array)
        //{
        //    for (int i = 0; i < array.Length-1; i++)
        //    {
        //        for (int j = 0; j < array.Length-i-1; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                int temp = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = temp;
        //            }
        //        }
        //    }
        //}

        #endregion bubble sort


        #region 17. Write a program to find pairs from array whose sum is equal to 30.

        //static void FindPairsWithSum(int[] arr,int TargetSum)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = i+1; j < arr.Length; j++)
        //        {
        //            if (arr[i] + arr[j] == TargetSum)
        //            {
        //                Console.WriteLine($"Target sum pair found : {TargetSum}");

        //            }
        //        }
        //    }
        // }
        #endregion 17. Write a program to find pairs from array whose sum is equal to 30.









    }
}

