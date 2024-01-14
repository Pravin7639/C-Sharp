using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.RollNumber = 1;
            s1.Name = "Pravin";
            // s1.Gender = "Male"; // for normal use
            //s1.Gender = 1;
            s1.Gender = Gender.Male;
            //s1.Subject = Subject.Maths; //from we can access all subject  

            //Console.WriteLine($" Roll Number : {s1.RollNumber}  " +
            //    $"Name : {s1.Name} Gender : {GetGender(s1.Gender)}");

            Console.WriteLine($" Roll Number : {s1.RollNumber}  " +
                $"Name : {s1.Name} Gender : {s1.Gender}");


            Student s2 = new Student();
            s2.RollNumber = 2;
            s2.Name = "Pawan";
            // s2.Gender = "Bond007";//for normal use but this is not acceptable
            //s2.Gender = 1;  //but by using this gender is consverted into INTEGER value
            s2.Gender = Gender.Male;



            //Console.WriteLine($" Roll Number : {s2.RollNumber}  " +
            //    $"Name : {s2.Name} Gender : {GetGender(s2.Gender)}");

            Console.WriteLine($" Roll Number : {s2.RollNumber}  " +
               $"Name : {s2.Name} Gender : {s2.Gender}");



            Student s3 = new Student();
            s3.RollNumber = 3;
            s3.Name = "raj";
            s3.Gender = Gender.unknown;

            Console.WriteLine($" Roll Number : {s3.RollNumber}  " +
              $"Name : {s3.Name} Gender : {s3.Gender}");



            Type t = Enum.GetUnderlyingType(typeof(Gender));
            Console.WriteLine($"Under Lying Type : {t.Name}"); // op-->Int32



            Console.WriteLine("All Items From enum");
            string[] names = Enum.GetNames(typeof(Gender));
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($" {names[i]}  ");
            }
            Console.WriteLine();




            int[] values = (int[])Enum.GetValues(typeof(Gender));
            Console.WriteLine("All Values of Enum Items");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"{values[i]}  ");
            }
            Console.WriteLine();






            Console.ReadLine();
        }

        //when we create enum it will not take part in execution
        static string GetGender(int gender)
        {
            switch (gender)
            {
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Inavalid Gender";

            }

        }


    }
}
