using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.RollNumber = 1;
            s.Name = "Pravin";
            s.City = "Pune";
            s.Details();

            Student s2 = new Student();
            s2.RollNumber = 7;
            s2.Name = "Ram";
            s2.City = "Ayodhya";
            s2.Details();


            s2.RollNumber = 9;
            s2.Name = "Pawan";
            s2.City = "Pune";
            s2.Details();
            ////////////////////////////////////////////////////////////////////////////////////////

            Circle c1 = new Circle();
            c1.Radius = 5;
            c1.Area();

            c1.Radius = 10;
            c1.Area();



            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string City { get; set; }


        public void Details()
        {
            Console.WriteLine($"Roll Number : {RollNumber} Name : {Name} City : {City}");
        }
    }

    public class Circle
    {
        public int Radius { get; set; }
        public static double PI = 3.143;

        public void Area()
        {
            Console.WriteLine($"Area of Circle : {Radius * Radius * PI}");
        }
    }

}
