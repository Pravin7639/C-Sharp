using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructors
{
   public class Student
    {
        public int RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Student()  /// Constructor without Parameter
        {

        }


        public Student(int rn, string fn, string ln)  /// Constructor with Parameter
        {
            this.RollNumber = rn;
            this.FirstName = fn;
            this.LastName = ln;

        }

        public void Details()
        {
            Console.WriteLine($"Roll Number : {RollNumber} Name : {FirstName} {LastName}");
        }








        ///////////////COPY CONSTRUCTOR//////////////////////////
        ///

        public Student( Student s)
        {
            this.RollNumber = s.RollNumber;
            this.FirstName = s.FirstName;
            this.LastName = s.LastName;
        }




    }
}
