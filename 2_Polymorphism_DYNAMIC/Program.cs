using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Polymorphism_DYNAMIC
{
    class Program
    {
        ////////////DYNAMIC POLYMORPHISM// Runtime polymorphism//////////////////////////////
        ///


        static void Main(string[] args)
        {
            #region Examples
            //    Animal a1 = new Animal();
            //    a1.AnimalSound();

            //    Animal a2 = new Pig();
            //    a2.AnimalSound();

            //    Animal a3 = new Dog();
            //    a3.AnimalSound();

            //    Pig p1 = new Pig();
            //    p1.AnimalSound();

            //    Dog d1 = new Dog();
            //    d1.AnimalSound();
            #endregion Examples






            Console.ReadLine();
        }
    }



    #region Examples
    //class Animal
    //{
    //    public virtual void AnimalSound()
    //    {
    //        Console.WriteLine("The animal makes a sound");
    //    }
    //}

    //class Dog : Animal
    //{      
    //    public override void AnimalSound()
    //    {
    //        Console.WriteLine("The dog makes a sound : bow bow ");
    //    }   
    //}


    //class Pig : Animal
    //{
    //    public override void AnimalSound()
    //    {
    //        Console.WriteLine("The Pig makes a sound : wee wee");
    //    }
    //}
    #endregion Examples




    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }



        public Vehicle(string make, string model, int year, int price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;

        }


        public void Details()
        {
            Console.WriteLine($"Details : {Make} {Model} {Year} Price : {Price} ");
        }

    }



    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public bool IsConvertible { get; set; }


        public Car(string make, string model, int year, int price, int numberOfDoors, bool isConvertible) 
            : base( make,  model,  year, price)
        {
            this.NumberOfDoors = numberOfDoors;
            this.IsConvertible = isConvertible;
        }

        public void Start()
        {
            Console.WriteLine("Car is Started");
        }

        public void Stop()
        {
            Console.WriteLine("Car is Stopped");
        }

    }


    public class MotarCycle : Vehicle
    {
        public bool HasSideCar { get; set; }
    
    
        public MotarCycle(string make, string model, int year, int price,bool hasSideCar)
            : base ( make, model, year, price)
        {
            this.HasSideCar = hasSideCar;
        }

        public void Wheelie()
        {
            Console.WriteLine("Motorcycle is doing a wheelie.");
        }



    }




}
