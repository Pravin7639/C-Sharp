using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  String Type

            //string str = "pawan";
            //Console.WriteLine(str);

            //string s = str.ToUpper();
            //Console.WriteLine(s);

            //s = str.ToLower();
            //Console.WriteLine(s);


            //s = str.ToCapitalCase();
            //Console.WriteLine(s);



            #endregion  String Type


            #region Object Type
            ////BMW b = new BMW();
            ////b.Id = 45;
            ////b.Print();
            ////b.PrintB();

            ////AUDI a = new AUDI();
            ////a.Print();


            //BMW o1 = new BMW();
            //o1.Print("A");
            //o1.Print();

            //AUDI o2 = new AUDI();
            //o2.Print("B");
            //o2.Print();
            #endregion Object Type



            int num = 40;
            int num1 = num.Increment();
            Console.WriteLine(num1);

            double d = 35.45;
            double d1 = d.Increment();
            Console.WriteLine(d1);


            string str = "Hello";
            string str1 = str.AddString();
            Console.WriteLine(str1);

            str = "Good Morning";
            str1 = str.AddString();
            Console.WriteLine(str1);






            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int> { 4, 5, 6 };
            list1.Concatenate(list2);
            Console.WriteLine(string.Join(", ", list1)); 
            // Output: 1, 2, 3, 4, 5, 6
     //if we want to cancat two list then their datatype should be same





        Console.ReadLine();
        }
    }

    public static class StringHelper 
    {
        public static string ToCapitalCase(this string str)
        {
            string result= string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    result += str[i].ToString().ToUpper();
                }
                else
                {
                    result += str[i];
                }

            }
            return result;


        }
    }





    public interface ICar { }

    public class BMW : ICar
    {
        public int Id { get; set; }

        //public static void PrintA()
        //{
        //    Console.WriteLine(Id);  // error //static method can access only static member
        //}


        public void PrintB()
        {
            Console.WriteLine(this.Id);
        }

        //public void Print()
        //{
        //    Console.WriteLine($"Print() : {GetType().Name}");
        //}

    }

    public class AUDI : ICar
    {
        //public void Print()
        //{
        //    Console.WriteLine($"Print() : {GetType().Name}");
        //}
    }

    public static class CarHelper
    {
        public static void Print(this ICar c1, string s = "Pravin")
        {
            Console.WriteLine($"Print() : {s} : {c1.GetType().Name}");
        }
    }


    public static class IntExtention
    {
        public static int Increment(this int num)
        {
            return num + 5;
        }
    }



    public static class DoubleExtention
    {
        public static double Increment(this double d)
        {
            return d + 10.0;
        }
    }


    public static class StringExtention
    {
        public static string AddString(this string str)
        {
            return str + " " + "Pawan";
        }
    }



    public static class ListExtensions
    {
        // Example 5: Concatenate two lists
        public static void Concatenate<T>(this List<T> list, List<T> otherList)
        {
            list.AddRange(otherList);
        }
    }




}
