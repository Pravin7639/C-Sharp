using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_AbtractionEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {



            //    //You can insert new student data

            //    Student s1 = new Student()
            //    {
            //        RollNumber = 1,
            //        Name = "Pravin",
            //        Gender = "Male"
            //    };
            //    s1.Insert();

            //    //if (s1.IsValid())
            //    //{
            //    //    s1.Insert(); // we can insert data
            //    //}  //when IsValid is Private thats why error is occure

            //    Student s2 = new Student();
            //    s2.Insert();




            Student s = new Student(45, "Rohit", "Male");
            s.Insert();





            Console.ReadLine();
        }
    }

    public class Student 
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }


        public Student(int rn, string name, string gender)
        {
            this.RollNumber = rn;
            this.Name = name;
            this.Gender = gender;

        }

        private bool IsValid()
        {
            if (RollNumber > 0 && !string.IsNullOrEmpty(Name) &&
                !string.IsNullOrEmpty(Gender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void Insert()
        {
            if (IsValid())
            {
                Console.WriteLine($"Roll Number : {RollNumber} Name : {Name} " +
                    $"Gender : {Gender}");
                Console.WriteLine("New Student Data Inserted Successfully");
            }
            else
            {
                Console.WriteLine("Invalid Data To Insert");
            }
        }





    }



}
