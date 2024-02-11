using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Abstract_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {

            #region class example
            ////Shape s1 = new Shape();
            ////s1.Draw();

            //Circle c1 = new Circle();
            //c1.Draw();

            //Rectangle r1 = new Rectangle();
            //r1.Draw();

            //Triangle t1 = new Triangle();
            //t1.Draw();

            #endregion class example


            #region Class Problem
            ////  Customer c1 = new Customer();
            //// We can not create object of ABSTRACT Class

            //Customer c1 = new SilverCustomer();
            //c1.PrintTicket();

            //Customer c2 = new GoldCustomer();
            //c2.PrintTicket();

            //Customer c3 = new PlatiniumCustomer();
            //c3.PrintTicket();

            //SilverCustomer sc = new SilverCustomer();
            //sc.PrintTicket();

            //GoldCustomer gc = new GoldCustomer();
            //gc.PrintTicket();

            //PlatiniumCustomer pc = new PlatiniumCustomer();
            //pc.PrintTicket();
            #endregion Class Problem



            //Shape s1 = new Circle();
            //s1.CalculateArea(5);
            //s1.CalculateArea(5, 5);
            //Shape s2 = new Rectangle();
            //s2.CalculateArea(10);
            //s2.CalculateArea(10, 10);



            Console.ReadLine();
        }
    }


    #region class example

    //public abstract class Shape
    //{
    //    public abstract void Draw();


    //    //public abstract void Draw1()
    //    //{
    //    //    Console.WriteLine("Draw ");
    //    //}
    //    //abstact class does not have body 
    //}

    //public class Circle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Draw a Circle");
    //    }
    //}

    //public class Rectangle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Draw a Rectangle ");
    //    }

    //}

    //public class Triangle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Draw a Circle");
    //    }
    //}

    #endregion class example



    #region Class Problem
    //public abstract class Customer
    //{

    //    public Customer()
    //        {
    //        Console.WriteLine("Customer Constructor() called");
    //        }
    //    public void ShowTimings()
    //    {
    //        Console.WriteLine("** ALL TODAYS SHOWS **");
    //    }

    //    public abstract void PrintTicket();

    //}


    //public class SilverCustomer : Customer
    //{
    //    public SilverCustomer()
    //      {
    //        Console.WriteLine("Silver Customer() constructor called");  
    //       }
    //    public override void PrintTicket()
    //    {
    //        Console.WriteLine("Silver Ticket Printed");
    //    }
    //}

    //public class GoldCustomer : Customer
    //{
    //    public GoldCustomer()
    //    {
    //        Console.WriteLine("Gold Customer() constructor called");

    //    }
    //    public override void PrintTicket()
    //    {
    //        Console.WriteLine("Gold Ticket Printed");
    //    }
    //}
    //public class PlatiniumCustomer:Customer
    //{
    //    public PlatiniumCustomer()
    //    {
    //        Console.WriteLine("Platinium Customer() constructor called");

    //    }
    //    public override void PrintTicket()
    //    {
    //        Console.WriteLine("Platinium Ticket Printed");
    //    }
    //}

    #endregion Class Problem



    //public abstract class Shape
    //{
    //    public double Radius;
    //    public double Width;
    //    public double Height;

    //    public abstract void CalculateArea(double d);
    //    public abstract void CalculateArea(double d1, double d2);
    //}

    //public class Circle : Shape
    //{
    //    public double PI = 3.14;

    //    public override void CalculateArea(double R)
    //    {
    //        Console.WriteLine($"Area of Circle is {PI * R * R}");
    //    }

    //    public override void CalculateArea(double r1, double r2)
    //    {
    //        //  Console.WriteLine($"Area of Circle is {PI * r1 * r2}");
    //    }

    //}

    //public class Rectangle : Shape
    //{


    //    public override void CalculateArea(double r)
    //    {
    //        // Console.WriteLine($"Area of Rectangle is {r * r}");
    //    }
    //    public override void CalculateArea(double h, double w)
    //    {
    //        Console.WriteLine($"Area of Rectangle is {h * w}");
    //    }
    //}


}
