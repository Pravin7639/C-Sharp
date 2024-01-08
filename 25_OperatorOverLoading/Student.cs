using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OperatorOverLoading
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(int rn, string fn, string ln)
        {
            this.RollNumber = rn;
            this.FirstName = fn;
            this.LastName = ln;

        }
        public static bool operator ==(Student s1, Student s2)
        {
            return s1.RollNumber == s2.RollNumber &&
                s1.FirstName == s2.FirstName &&
                s1.LastName == s2.LastName;
        }


        public static bool operator !=(Student s1, Student s2)
        {
            return s1.RollNumber != s2.RollNumber &&
                s1.FirstName != s2.FirstName &&
                s1.LastName != s2.LastName;
        }

        public static Student operator +(Student s1, Student s2)
        {
            int rn = s1.RollNumber + s2.RollNumber;
            string fn = s1.FirstName + " " + s2.FirstName;
            string ln = s1.LastName + " " + s2.LastName;

            return new Student(rn, fn, ln);

        }


    }
}
