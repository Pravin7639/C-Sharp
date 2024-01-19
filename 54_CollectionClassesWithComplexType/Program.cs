using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_CollectionClassesWithComplexType
{
    class Program
    {
        static void Main(string[] args)
        {


            Student s1 = new Student() { RollNumber = 1, Name = "Pravin", City = "Pune" };
            Student s2 = new Student() { RollNumber = 2, Name = "Sachin", City = "Mumbai" };
            Student s3 = new Student() { RollNumber = 3, Name = "Pawan", City = "Pandharpur" };
            Student s4 = new Student() { RollNumber = 4, Name = "Vihaan", City = "Satara" };
            Student s5 = new Student() { RollNumber = 5, Name = "Aryan", City = "Kolhapur" };

            #region List<>

            //List<Student> students = new List<Student>() { s1, s2, s3, s4, s5 };
            ////students.Add(s1);
            ////students.Add(s2);
            ////students.Add(s3);
            ////students.Add(s4);
            ////students.Add(s5);


            //Console.WriteLine("*** ALL STUDENTS ***");

            //foreach (Student item in students)
            //{
            //    Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.Name} " +
            //        $" City : {item.City} ");
            //}


            #endregion List<>



            #region Dictionary<int, Student>

            //Dictionary<int, Student> students = new Dictionary<int, Student>();
            //students.Add(s1.RollNumber, s1);
            //students.Add(s2.RollNumber, s2);
            //students.Add(s3.RollNumber, s3);
            //students.Add(s4.RollNumber, s4);
            //students.Add(s5.RollNumber, s5);

            //Student s = students[2];
            //Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} City : {s.City} ");

            //Console.WriteLine("*** ALL STUDENTS ***");
            //foreach (KeyValuePair<int, Student> item in students)
            //{
            //    Console.WriteLine($"Key : {item.Key} ");
            //    Student ss = item.Value;
            //    Console.WriteLine($"Roll Number : {ss.RollNumber} " +
            //        $"Name : {ss.Name} City : {ss.City} ");

            //}


            #endregion Dictionary<int, Student>







            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
