using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();
            s1.RollNumber = 1;
            s1.Name = "Pravin";
            s1.City = "Pune";
            s1.Details();



            Student s2 = new Student(2, "Pawan", "Pandharpur");
            s2.Details();


            //we can change the value of static member
            Student.CourseName = "C#";

            s2.Details();

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }   // Instance of Class
        public string Name { get; set; }
        public string City { get; set; }

        public static string CourseName = "DOT NET";

        public Student()   // Constructor Without Parameter
        {

        }


        public Student(int rn, string name, string city) // Constructor With Parameter
        {
            this.RollNumber = rn;
            this.Name = name;
            this.City = city;

        }

        public void Details()
        {
            Console.WriteLine($"Roll Number : {RollNumber} Name : {Name} City : {City} " +
                $"Course Name : {CourseName} ");
        }

    }


}
