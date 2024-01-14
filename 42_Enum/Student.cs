using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Enum
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }

        //   public string Gender { get; set; }    //for normal

        //public int Gender { get; set; }  

        public Gender Gender { get; set; }

        public Subject Subject { get; set; }



    }

    //  public enum Gender  : byte --> for conversion // enum created
    public enum Gender
    {
        Male = 10, Female, unknown
    }

    public enum Subject
    {
        Marathi, Hindi, English, Maths, Chemistry, Physics
    }
}
