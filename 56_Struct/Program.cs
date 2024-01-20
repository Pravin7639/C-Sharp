using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer();
            //c1.Details();

            //Customer c2 = new Customer(1, "Pawan", "Mane");
            //c2.Details();




            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();
            Console.WriteLine(dt1);      
            ///  1/1/0001 12:00:00 AM


            //assigns year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31);
            Console.WriteLine(dt2);       
            ///  12/31/2015 12:00:00 AM



            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine(dt3);
            ///  12/31/2015 5:10:20 AM



            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dt4);
            ///   12/31/2015 5:10:20 AM



            //DateTime dt = new DateTime(2015, 12, 32);
            //Console.WriteLine(dt);
            ////throws exception: day out of range


            Console.WriteLine("\n-----------------------------------------");


            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            Console.WriteLine($"Date : {today.ToShortDateString()}");
            Console.WriteLine($"Date : {today.ToShortTimeString()}");


            //date formating


            Console.WriteLine(today.ToString("dddd, dd, M, YYYY"));


            DateTime today1 = DateTime.Today;
            Console.WriteLine(today1);





            Console.ReadLine();
        }
    }

    public struct Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //public Customer()
        //{
        //    Console.WriteLine("Public class Customer() Constructor Called");
        //}


        public Customer(int cid, string fn, string ln)
        {
            this.CustomerId = cid;
            this.FirstName = fn;
            this.LastName = ln;
        }

        public void Details()
        {
            Console.WriteLine($"Customer Id : {CustomerId} Name : {FirstName} {LastName} ");
        }




    }


    //public class SilverCustomer : Customer 
    //{ 

    //}


}
//it does not contain any Parameter less constructor
//this class can not be inherited in another class
