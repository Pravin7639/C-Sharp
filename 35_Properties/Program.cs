using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //   //Student s1 = new Student();
            //   //s1.RollNumber = 1;  // assigning//setting//write
            //   //s1.Name = "Pravin";
            //   //s1.PassMark = 35;
            //   //Console.WriteLine($"Roll Number : {s1.RollNumber} Name : {s1.Name} Pass Mark : {s1.PassMark}");
            //   //////  read//Get//Fetch

            //   //Student s2 = new Student();
            //   //s2.RollNumber = -1;
            //   //s2.Name = null;
            //   //s2.PassMark = 10;
            //   //Console.WriteLine($"Roll Number : {s2.RollNumber} Name : {s2.Name} Pass Mark : {s2.PassMark}");


            //   Student s2 = new Student();
            //   // s2.RollNumber = -1;
            //   s2.SetRollNumber(-1);
            //   // s2.SetName("Pawan");
            //   s2.SetName(null);
            ////   s2.GetPassMark(10);  // error

            //   //s2.Name = null;
            //   //s2.PassMark = 10;
            //   Console.WriteLine($"Roll Number : {s2.GetRollNumber()} Name :{s2.GetName()} Pass Mark :{s2.GetPassMark()} ");

            Student s = new Student();
            s.RollNumber = 10;
            s.Name = "Pravin";

            Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name}");

            Student s1 = new Student();
            s1.RollNumber = -10;
            s1.Name = null;
            s1.Passmark = 10;
            Console.WriteLine($"Roll Number : {s1.RollNumber} Name : {s1.Name} Pass Mark : {s1.Passmark}");


            Console.ReadLine();
        }
    }
    //public class Student
    //{
    //    public int RollNumber;
    //    public string Name;
    //    public int PassMark = 35;
    //}


    //public class Student
    //{
    //    private int _rollNumber; //using this we can control the value //encapsulation
    //    private string _name;
    //    private int _passMark = 35;

    //    public void SetRollNumber(int rollNumber)
    //    {
    //            if (rollNumber > 0)
    //            {
    //                _rollNumber = rollNumber;
    //            }
    //            else
    //          {
    //                _rollNumber = 0;
    //              Console.WriteLine("RollNumber Can Not Be Negative");
    //          }
    //       }    
    //    public int GetRollNumber()
    //    {
    //        return _rollNumber;
    //    }

    //    public void SetName(string name)
    //    {
    //        _name = name;
    //    }

    //    public string GetName()
    //    {
    //        return !string.IsNullOrEmpty(_name)? _name :"No Name Provided" ;
    //    }

    //    public int GetPassMark()
    //    {
    //        return _passMark;
    //    }

    // }

    public class Student
    {
        private int _rollNumber;
        private string _name;
        private int _passMark = 35;
        private string _city;

        public int RollNumber
        {
            get
            {
                return _rollNumber;
            }
            set
            {
                if (value > 0)
                {
                    _rollNumber = value;
                }
                else
                {
                    _rollNumber = 0;
                    Console.WriteLine("Roll Number can not be Negative");
                }
            }
        }


        public string Name
        {
            get
            {
                return !string.IsNullOrEmpty(_name) ? _name : "No Name Provided";
            }
            set
            {
                _name = value;
            }
        }


        public int Passmark
        {
            get
            {
                return _passMark;
            }
            set
            {
                _passMark = value;
            }
        }


       
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }



        public string Email { get; set; }





    }






}
