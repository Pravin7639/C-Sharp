using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0__Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region class Example

            // ICustomer2 c1 = new ICustomer2();  //cann't create

            ICustomer2 c1 = new SilverCustomer();
            c1.PrintTicket();
            c1.ShowTimings();

            ICustomer2 c2 = new GoldCustomer();
            c2.PrintTicket();
            c2.ShowTimings();

            SilverCustomer sc = new SilverCustomer();
            sc.PrintTicket();
            sc.ShowTimings();

            GoldCustomer gc = new GoldCustomer();
            gc.PrintTicket();
            gc.ShowTimings();
           
            Console.WriteLine("--------------------------------------------------------------");

            #endregion class Example

            #region Random Example

            IAnimal ia = new Pig();
            ia.AnimalSound();
            ia.Run();

            IAnimal ia1 = new Horse();
            ia1.AnimalSound();
            ia1.Run();
            Console.WriteLine("--------------------------------------------------------------");
            #endregion Random Example

            #region Random Example 2
            ICar ic = new EletricCar();
            ic.Start();
            ic.MinimumRange();

            ICar ic1 = new GasolineCar();
            ic1.Start();
            ic1.MinimumRange();
            Console.WriteLine("-----------------------------------------------------------------");
            #endregion Random Example 2



            ////Pattern Printing

            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j < 6 - i; j++)
            //    {
            //        Console.Write(j + 1);
            //    }
            //    Console.WriteLine();
            //}




            Console.ReadLine();
        }
    }



    #region class Example

    public interface ICustomer1
    {

        //public int RollNumber;            ///  Fields cannot be written in Interface

        void ShowTimings();
        // public keyword cannot be written in Method
        //
    }

    public interface ICustomer2 : ICustomer1
    {
        void PrintTicket();
    }

    public class SilverCustomer : ICustomer2
    {
        public void PrintTicket()
        {
            Console.WriteLine("Silver Customer : PrintTicket() Method Called");
        }
        public void ShowTimings()
        {
            Console.WriteLine("Silver Customer : ShowTiming() Method Called ");
        }

    }

    public class GoldCustomer : ICustomer2
    {
        public void PrintTicket()
        {
            Console.WriteLine("Gold Customer : PrintTicket() Method Called");
        }
        public void ShowTimings()
        {
            Console.WriteLine("Gold Customer : ShowTiming() Method Called ");
        }
    }

    #endregion class Example



    #region Random Example

    public interface IAnimal
    {
        void AnimalSound();
        void Run();
    }

    public class Pig : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Pig say's Wee Wee");
        }

        public void Run()
        {
            Console.WriteLine("Run fast");
        }

    }

    public class Horse : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Horse say's ");
        }

        public void Run()
        {
            Console.WriteLine("HORSE RUN TOO FAST");
        }
    }

    #endregion Random Example



    #region Random Eaxample 2
    public interface ICar
    {
        void Start();
        void MinimumRange();
    }

    public class EletricCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("Eletric car started");
        }
        public void MinimumRange()
        {
            Console.WriteLine("As per Battery Charged / Percentage");
        }
    }


    public class GasolineCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("Gasoline Car Started");
        }
        public void MinimumRange()
        {
            Console.WriteLine("As per fuel filled in a Car ");
        }

    }
    #endregion Random Eaxample 2





}
