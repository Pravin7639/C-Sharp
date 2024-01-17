using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_const_readonly_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.RollNumber = 1;
            s1.Name = "Pravin";
            //   s1.CompanyName = "V#";

            Console.WriteLine($"Roll Number :{s1.RollNumber}  " +
                $"Name : {s1.Name}  " +
                $"Company Name : {s1.CompanyName} ");


            //for static and const keword we have to WRITE Student.CompanyName
            //for Normal and ReadOnly keyword we have to WRITE s1.CompanyName


            Student s2 = new Student();
            s2.RollNumber = 2;
            s2.Name = "Pawan";
            // s2.CompanyName = "V#"; //we cannot change the value apart from constructor of READONLY 


            //Student.CompanyName = "TCS";//after declaration of const fields it gives error

            Console.WriteLine($"Roll Number :{s2.RollNumber}  " +
                $"Name : {s2.Name}  " +
                $"Company Name : {s2.CompanyName} ");











            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }

        // public static string CompanyName = "V#";

        //  public const string CompanyName = "V#";//mandatory to initialize the value

        public readonly string CompanyName;//not mandatory to initialize


        public Student()
        {
            // Runtime
            CompanyName = "V#";
        }



    }
}
