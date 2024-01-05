using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Method_constructor_class
{
    class Program
    {
        static void Main(string[] args)
        {


            ////////Simple Class and Method/////////
            
            Rectangle r1 = new Rectangle();
            r1.Length = 5;
            r1.Width = 5;
            double area = r1.CalculateArea();
            Console.WriteLine($"The area of ReactAngle is : {area}");


            //////////// Constructors and Initialization////////////////

            Person p1 = new Person("Pravin", 23);
            Console.WriteLine($"Name : {p1.Name} Age : {p1.Age}");



            /////////////// Method Overloading//////////////
            Calculator c1 = new Calculator();
            int sum1 = c1.Add(5, 5);
            int sum2 = c1.Add(5, 5, 5);

            Console.WriteLine($"Sum of two numbers is : {sum1}");
            Console.WriteLine($"Sum of three numbers is : {sum2}");




            Console.ReadLine();
        }
    }



    public class Rectangle
    {
        public double Length;
        public double Width;

        public double CalculateArea()
        {
            return Length * Width;

        }
    }


    public class Person
    {
        public string Name;
        public int Age;


        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }
    }




    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;

        }
    }







}
