using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_GenericCollectionClasses
{
    class Program
    {
        static void Main(string[] args)
        {


            #region List<>

            // //  ArrayList nums = new ArrayList();

            // //List<object> col = new List<object>();// behave like arraylist



            // List<int> numbers = new List<int>();
            // numbers.Add(10);
            // numbers.Add(20);
            // numbers.Add(30);
            // Console.WriteLine($"Number of Item : {numbers.Count}");

            // foreach (var item in numbers)
            // {
            //     Console.Write($"{item} ");
            // }
            //// Console.WriteLine();
            // Console.WriteLine("\n----------------------------------------");




            // List<int> temp = new List<int>() { 40, 50};
            // numbers.AddRange(temp);

            // foreach (var item in numbers)
            // {
            //     Console.Write($"{item} ");
            // }
            // Console.WriteLine("\n----------------------------------------");



            // numbers.Insert(1, 15);
            // foreach (var item in numbers)
            // {
            //     Console.Write($"{item} ");
            // }
            // Console.WriteLine("\n----------------------------------------");


            // bool b1=numbers.Contains(30);
            // Console.WriteLine($"30 Exists : {b1}");
            // b1 = numbers.Contains(50);
            // Console.WriteLine($"50 Exists : {b1}");
            // Console.WriteLine("\n----------------------------------------");


            // numbers.Remove(30);
            // numbers.RemoveAt(0);
            // numbers.RemoveRange(2, 1);

            // foreach (var item in numbers)
            // {
            //     Console.Write($"{item} ");
            // }
            // Console.WriteLine("\n----------------------------------------");


            // numbers.Clear();
            // Console.WriteLine($"Number of item : {numbers.Count}");





            #endregion list<>



            #region Dictonary<>

            //Dictionary<int, string> students =
            //    new Dictionary<int, string>();

            //students.Add(1, "Pravin");
            //students.Add(2, "Pawan");
            //students.Add(3, "Ram");

            //Console.WriteLine($"Numbers of Item : {students.Count}");

            ////foreach (var item in students)
            ////{
            ////    Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
            ////}



            //////// for iterating on dictonary we use KeyValuePair Keyword
            /////

            //foreach (KeyValuePair<int, string> item in students)
            //{
            //    Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
            //}



            //bool b1 = students.ContainsKey(2);
            //Console.WriteLine($"2 key exists? : {b1}");

            //b1 = students.ContainsValue("Pawan");
            //Console.WriteLine($"Pawan Value exists ? : {b1}");

            //string name = students[2];
            //Console.WriteLine(name);




            #endregion Dictonary<>



            #region Stack<>

            //Stack<string> names = new Stack<string>();
            //names.Push("Pawan");
            //names.Push("Pravin");
            //names.Push("Ram");

            //Console.WriteLine($"Number of Items : {names.Count}");

            //string name = names.Pop();
            //Console.WriteLine(name);
            //Console.WriteLine($"Number of Items : {names.Count}");

            //name = names.Peek();
            //Console.WriteLine(name);
            //Console.WriteLine($"Number of Items : {names.Count}");

            #endregion Stack<>






            #region Queue<>

            //Queue<string> names = new Queue<string>();
            //names.Enqueue("Pravin");
            //names.Enqueue("Pawan");
            //names.Enqueue("Ram");

            //Console.WriteLine($"Number of Items : {names.Count}");


            //string name = names.Dequeue();
            //Console.WriteLine(name);
            //Console.WriteLine($"Number of Items : {names.Count}");

            //name = names.Peek();
            //Console.WriteLine(name);
            //Console.WriteLine($"Number of Items : {names.Count} ");


            #endregion Queue<>






            Console.ReadLine();
        }
    }
}
