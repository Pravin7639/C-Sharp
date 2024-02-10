using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Polymorphism
{

    /////////////////  COMPILE TIME POLYMORPHISM // STATIC POLYMRPHISM///////////////////////////////////
    class Program
    {
        static void Main(string[] args)
        {
           
            #region Animal Example
            Animal a1 = new Animal();
            a1.AnimalSound();

            Animal a2 = new Dog();
            a2.AnimalSound();

            Animal a3 = new Pig();
            a3.AnimalSound();

            Pig p1 = new Pig();
            p1.AnimalSound();

            Dog d1 = new Dog();
            d1.AnimalSound();

            Console.WriteLine("--------------------------------------------------------------");

            #endregion Animal Example

            
            #region Employee Example
            Employee e = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Raj",
                LastName = "Raut"
            };
            e.Details();

            PermanantEmployee e1 = new PermanantEmployee()
            {
                HourlySalary = 700
            };
            e1.Details();

            TemporaryEmployee e2 = new TemporaryEmployee()
            {
                HourlySalary = 400
            };
            e2.Details();

            Console.WriteLine("--------------------------------------------------------------");

            #endregion Employee Example


            #region Vehicle Example
            Car c = new Car("Toyota", "Ciaz", 2022, 250000, 4, false);
            c.Details();
            c.Start();
            c.Stop();


            c = new Car("TATA", "Safari", 2022, 500000, 4, false);
            c.Details();
            c.Start();
            c.Stop();


            MotarCycle mc = new MotarCycle("Honda", "Shine", 2023, 75000, false);
            mc.Details();
            mc.wheelie();

            Truck t = new Truck("TATA", "Echer", 2023, 100000, 5000);
            t.Details();
            t.LoadCargo();
            t.UnloadCargo();
            Console.WriteLine("--------------------------------------------------------------");
            #endregion Vehicle Example


            #region Library Example

            LibraryItem l1 = new LibraryItem();
            l1.Tital = "The Catcher in the Rye";
            l1.Author = "J.D. Salinger";
            l1.PublicationDate = new DateTime(1951, 7, 16);
            Console.WriteLine("Lirary Information");
            l1.DisplayItemInfo();
            Console.WriteLine("-------------------------------------------------------------");


            Book b1 = new Book()
            {
                Tital = "The Catcher in the Rye",
                Author= "J.D. Salinger",
                PublicationDate=new DateTime(1951, 7, 16),
                Genre = "Fiction"
            };
            Console.WriteLine("Book Information");
            b1.DisplayItemInfo();
            Console.WriteLine("-------------------------------------------------------------");


            Magazine m1 = new Magazine()
            {
                Tital = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                PublicationDate = new DateTime(1951, 7, 16),
                IssueNumber=1000
            };
            Console.WriteLine("Magzine Information");
            m1.DisplayItemInfo();
            Console.WriteLine("-------------------------------------------------------------");


            DVD dvd = new DVD()
            {
                Tital = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                PublicationDate = new DateTime(1951, 7, 16),
                Director= "Frank Darabont"
            };
            Console.WriteLine("DVD Information");
            dvd.DisplayItemInfo();
            Console.WriteLine("-------------------------------------------------------------");

            #endregion Library Example





            Console.ReadLine();
        }
    }



    #region Animal Example

    public class Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The animal makes sound ");
        }
    }

    public class Pig : Animal
    {
       new public void AnimalSound()
        {
            Console.WriteLine("The pig says : WEE WEE ");
        }
    }

    public class Dog : Animal
    {
       new public void AnimalSound()
        {
            Console.WriteLine("The Dog says : bow bow ");
        }
    }
    #endregion Animal Example


    #region Employee Example

    public class Employee
    {
        public int EmployeeId;
        public string FirstName;
        public string LastName;

        //public employee(int eid, string fn, string ln)
        //{
        //    this.employeeid = eid;
        //    this.firstname = fn;
        //    this.lastname = ln;
        //}


        public void Details()
        {
            Console.WriteLine($"Employee Id : {EmployeeId} First Name : {FirstName}  Last Name : {LastName}");
        }

    }

    public class PermanantEmployee : Employee
    {
        public int HourlySalary;

        public void Details()
        {
            Console.WriteLine($"Employee Id : {EmployeeId} First Name : {FirstName}  " +
                $"Last Name : {LastName}  Hourly Salary  {HourlySalary}");
        }

    }


    public class TemporaryEmployee : Employee
    {
        public int HourlySalary;

        public void Details()
        {
            Console.WriteLine($"Employee Id : {EmployeeId} First Name : {FirstName}  " +
                $"Last Name : {LastName}  Hourly Salary  {HourlySalary} ");

        }
    }
    #endregion Employee Example


    #region Vehicla Example
    public class Vehical
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    
    public Vehical(string make, string model, int year, double price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }


        public void Details()
        {
            Console.WriteLine($"Details : {Make}  {Model}  {Year} Price : {Price}");
        }
    
    
    
    }


    public class Car : Vehical
    {
        public int NumberOfDoors { get; set; }
        public bool IsConvertable { get; set; }

        public Car(string make, string model, int year, double price, int numberofdoors, bool isconvertable) 
            : base( make,  model,  year,  price)
        {
            this.NumberOfDoors = numberofdoors;
            this.IsConvertable = isconvertable;
        }

        public void Start()
        {
            Console.WriteLine("Car is Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Car is Stopping");
        }


    }



    public class MotarCycle : Vehical
    {
        public bool HasSideCar { get; set; }

        public MotarCycle(string make, string model, int year, double price, bool hassidecar) :
            base( make,  model,  year, price)
        {
            this.HasSideCar = hassidecar;
        }

        public void wheelie()
        {
            Console.WriteLine("Motorcycle is doing a wheelie");
        }


    }

    public class Truck : Vehical
    {
        public double PayloadCapacity { get; set; }

        public Truck(string make, string model, int year, double price, double payloadCapacity)
        : base(make, model, year, price)
        {
            PayloadCapacity = payloadCapacity;
        }

        public void LoadCargo()
        {
            Console.WriteLine("Truck is loading cargo");
        }

        public void UnloadCargo()
        {
            Console.WriteLine("Truck is unloading cargo");
        }

    }

    #endregion Vehicle Example


    #region Library Example
    public class LibraryItem
    {
        public string Tital { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }


        public virtual void DisplayItemInfo()
        {
            Console.WriteLine($"Tital : {Tital} ");
            Console.WriteLine($"Author : {Author} ");
            Console.WriteLine($"Publication Date : {PublicationDate.ToShortDateString()}");

        }
    }

    public class Book : LibraryItem
    {
        public string Genre { get; set; }

        public override void DisplayItemInfo()
        {
            base.DisplayItemInfo();
            Console.WriteLine($"Genre : {Genre}");
        }

    }

    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public override void DisplayItemInfo()
        {
            base.DisplayItemInfo();
            Console.WriteLine($"Issue Number : {IssueNumber}");
        }
    }
    public class DVD : LibraryItem
    {
        public string Director { get; set; }

        public override void DisplayItemInfo()
        {
            base.DisplayItemInfo();
            Console.WriteLine($"Director of DVD : {Director}");
        }

    }

    #endregion Libarary Example

}
