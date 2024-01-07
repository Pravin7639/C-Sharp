using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student(1, "Pravin", "Mane");   //// OBJECT INITILIZER SYNTAX   
            s1.Details();

            Student s2 = new Student(2, "Pawan", "Mane");
            s2.Details();


            Student s3 = new Student()
            {
                RollNumber = 9,
                FirstName = "Pawan",
                LastName = "mane"
            };
            s3.Details();



           Student s4 = new Student();
            s4.Details();





            /////////////////////////COPY CONSTRUCTOR//////////////////////////////////////
            ///
            Student s5 = s1;
            s5.Details();


            Student s6 = new Student();
            s6.RollNumber = s1.RollNumber;
            s6.FirstName = s1.FirstName;
            s6.LastName = s1.LastName;
            s6.Details();

            ///using copy constructor
            ///
            Student s7 = new Student(s2);
            s7.Details();










            Console.ReadLine();
        }
    }
}
