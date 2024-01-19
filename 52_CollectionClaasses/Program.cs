using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_CollectionClaasses
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Array

            // int[] nums = new int[2];
            // nums[0] = 10;
            // nums[1] = 20;
            //// nums[2] = 30;//Index out of Range Exception


            // for (int i = 0; i < nums.Length; i++)
            // {
            //     Console.WriteLine(nums[i]);
            // }

            #endregion Array


            #region ArrayList
            ////// Console.BackgroundColor = ConsoleColor.Red; //to change background colour

            //ArrayList numbers = new ArrayList();

            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);
            //Console.WriteLine("*** Orignal Array ***");
            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n--------------------------------------------");



            ////ICollection temp = new ArrayList() { 40, 50, 60 };
            //ArrayList temp = new ArrayList() { 40, 50, 60 };
            //numbers.AddRange(temp);

            //Console.WriteLine("*** AddRange(temp) : Orignal Collection ***");
            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n--------------------------------------------");



            ////numbers.Add(15);

            ////////////////////Adding particular element to a particular index//////////////

            //numbers.Insert(1, 15);

            //Console.WriteLine("*** Insert(1, 15) : Orignal Collection ***");
            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n--------------------------------------------");




            ///////////Adding Numbers at a Position of certain Range 


            ////ICollection temp1 = new ArrayList() { 40, 50, 60 };

            //ArrayList temp1 = new ArrayList() { 16, 17, 18 };

            //numbers.InsertRange(2, temp1);

            //Console.WriteLine("*** InsertRange(2, temp1) : Orignal Collection ***");


            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n--------------------------------------------");



            ////////////////// checking number is there or Not
            /////

            //bool b1 = numbers.Contains(19);
            //Console.WriteLine($"19 : {b1}");

            //b1 = numbers.Contains(30);
            //Console.WriteLine($"30 : {b1}");

            //Console.WriteLine("\n--------------------------------------------");

            ///////////// for remove//////
            ///////

            //numbers.Remove(15);
            //numbers.RemoveAt(0);
            //numbers.RemoveRange(0, 3);

            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n--------------------------------------------");


            #endregion ArrayList



            #region HashTable

            //   Hashtable students = new Hashtable();
            //   students.Add(1, "Pravin");
            //   students.Add(2, "Pawan");
            //   students.Add(3, "Ram");
            //  // students.Add(3, "Raj");   // key can not be duplicate


            //   Console.WriteLine("*** ALL ITEMS ***");
            ////to iterate on HashTable we have to use type of ITEM IS DictionaryEntry

            //   foreach (DictionaryEntry item in students)  // Forward Only
            //   {
            //       Console.WriteLine($"key : {item.Key}  Value : {item.Value} ");
            //   }
            //   // but it will print in reverse value

            //   //////////////////////////check value is there or not//
            //   ///
            //   bool b1 = students.ContainsKey(4);
            //   Console.WriteLine($"4 Key : {b1}");
            //   b1 = students.ContainsValue("Pawan");
            //   Console.WriteLine($" Pawan Value : {b1}");

            //  var val = students[2];
            //   Console.WriteLine($" 2 : {val}");


            #endregion HashTable



            #region Stack

            //Stack visitedSites = new Stack();
            //visitedSites.Push("Google.com");
            //visitedSites.Push("Facebook.com");
            //visitedSites.Push("Facebook.com/Friends");
            //visitedSites.Push("Facebook.com/user/ajay");

            //Console.WriteLine($"Number of Items : {visitedSites.Count}");
            ////  o/p--> 4

            //var site = visitedSites.Pop();
            //Console.WriteLine($"Returne : {site}");
            ////  o/p--> "Facebook.com/user/ajay"

            //site = visitedSites.Pop();
            //Console.WriteLine($"Return : {site}");
            //Console.WriteLine($"Number of Items : {visitedSites.Count}");
            ////  o/p--> "Facebook.com/Friends"   // 2

            //site = visitedSites.Peek();
            //Console.WriteLine($"Return : {site}");
            //Console.WriteLine($"Number of Items : {visitedSites.Count}");
            ////  o/p-->" Facebook.com "     // 2



            #endregion Stack



            #region Queue

            //Queue BankToken = new Queue();
            //BankToken.Enqueue("Pravin");
            //BankToken.Enqueue("Pawan");
            //BankToken.Enqueue("Ram");
            //BankToken.Enqueue("Raj");
            //BankToken.Enqueue("Sachin");

            //Console.WriteLine($"Number of items : {BankToken.Count}");

            //foreach (var item in BankToken)
            //{
            //    Console.WriteLine(item);
            //}

            //var token = BankToken.Dequeue();
            //Console.WriteLine($"Dequeue : {token}");
            //Console.WriteLine($"Number of items : {BankToken.Count}");

            //token = BankToken.Dequeue();
            //Console.WriteLine($"Dequeue : {token}");
            //Console.WriteLine($"Number of items : {BankToken.Count}");

            //token = BankToken.Peek();
            //Console.WriteLine($"Peek : {token}");
            //Console.WriteLine($"Number of items : {BankToken.Count}");

            #endregion Queue


            //when we use collection classes then there is no type saftey







            Console.ReadLine();

        }
    }
}
