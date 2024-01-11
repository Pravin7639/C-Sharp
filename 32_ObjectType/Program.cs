using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_ObjectType
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region GetType() Method

            //// To retrive type information
            //// 1. Typeof() operator--we can use with type name.
            //// 2. GetType() method -- we can use with variable.

            //int i = 10;
            ////Type i1 = typeof(int);
            //Type i1 = i.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");

            //bool b = true;
            //i1 = b.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");

            //string s = "Pravin";
            //i1 = s.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");

            ////Student s1 = new Student();
            ////i1 = s1.GetType();
            ////Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");


            ////object i = 10;
            ////object b = true;
            ////object s = "Pravin";
            ////object s1 = new Student();
            ///


            #endregion GetType() Method


            #region ToString() Method

            //int i = 10, j = 10;
            //Console.WriteLine($"{i} + {j} = {i + j}");
            //Console.WriteLine(i.ToString() + j.ToString());

            //double d1 = 10.5, d2 = 10.5;
            //Console.WriteLine(d1.ToString() + d2.ToString());

            //Student s1 = new Student() { FirstName = "Pravin", LastName = "Mane" };
            //Console.WriteLine(s1.ToString());
            //// if we override ToString method then we get meaningfull output else NamespaceName.ClassName

            //Student s2 = new Student() { FirstName = "Pawan", LastName = "Mane"};
            //Console.WriteLine(s2.ToString());



            #endregion ToString() Method


            #region Equals() Method

            ////int i = 10;
            ////int j = 10;
            ////if (i.Equals(j))
            ////{
            ////    Console.WriteLine("EQUAL");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("NOT EQUAL");
            ////}

            ////string str1 = "Pravin";
            ////string str2 = "Pravin";
            ////if (str1.Equals(str2))
            ////{
            ////    Console.WriteLine("EQUAL");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("NOT EQUAL");
            ////}

            //Student s1 = new Student() { FirstName = "Pawan", LastName = "Mane" };
            //Student s2 = new Student() { FirstName = "Pawan", LastName = "Mane" };

            //if (s1.Equals(s2))
            //{
            //    Console.WriteLine("EQUAL");
            //}
            //else
            //{
            //    Console.WriteLine("NOT EQUAL");
            //}





            #endregion Equals() Method


            #region GetHashCode() Method

            //int i = 10;
            //int j = 10;
            //int k = 11;
            //Console.WriteLine($"{i.GetHashCode()} : {j.GetHashCode()} : {k.GetHashCode()}");

            //string str1 = "Pravin";
            //string str2 = "Pravin";
            //string str3 = "Pawan";

            //Console.WriteLine($"str1 : {str1.GetHashCode()} " +
            //    $"str2 : {str2.GetHashCode()} " +
            //    $"str3 : {str3.GetHashCode()} ");

            //Student s1 = new Student() { FirstName = "Pravin", LastName = "Mane" };
            //Student s2 = new Student() { FirstName = "Pravin", LastName = "Mane" };
            //Student s3 = new Student() { FirstName = "Pawan", LastName = "Mane" };

            //Console.WriteLine($"{s1.GetHashCode()} :: {s2.GetHashCode()} :: {s3.GetHashCode()} ");


            #endregion GetHashCode() Method



            #region Compare Value With Ternary Operator

            //// int i = 10, j = 10;

            Student i = new Student() { FirstName = "Pravin", LastName = "Mane" };
            Student j = new Student() { FirstName = "Pravin", LastName = "Mane" };

            string result = (i == j) ? "EQUAL" : "NOT EQUAL";
            Console.WriteLine(result);

            result = (i.Equals(j)) ? "EQUAL" : "NOT EQUAL";
            Console.WriteLine(result);

            result = (i.GetHashCode() == j.GetHashCode()) ? "EQUAL" : "NOT EQUAL";
            Console.WriteLine(result);

            #endregion Compare Value







            Console.ReadLine();
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // it will use with complex type object
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }


        public override bool Equals(object obj)
        {
            Student s = obj as Student;
            return this.FirstName.Equals(s.FirstName) &&
                this.LastName.Equals(s.LastName);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

    }



}
