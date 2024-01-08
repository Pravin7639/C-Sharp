using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OperatorOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
             int j = 10;
            //int j = 20;
            if (i == j)
            {
                Console.WriteLine("EQUAL");
            }
            else
            {
                Console.WriteLine("NOT EQUAL");
            }


            string str1 = "Pawan";
             string str2 = "Pawan";
            //string s2 = "Pravin";
            if (str1 == str2)
            {
                Console.WriteLine("EQUAL");
            }
            else
            {
                Console.WriteLine("NOT EQUAL");
            }


            Student s1 = new Student(1, "Pravin", "Mane");
            //Student s2 = s1;
            Student s2 = new Student(1, "Pravin", "Mane");
            if (s1 == s2)
            {
                Console.WriteLine("EQUAL");
            }
            else
            {
                Console.WriteLine("NOT EQUAL");
            }



            Student s3 = s1 + s2;
            Console.WriteLine($" {s3.RollNumber}  :  {s3.FirstName}  :  {s3.LastName} ");




            Console.ReadLine();
        }
    }
}
