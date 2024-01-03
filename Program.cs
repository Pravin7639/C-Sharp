using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Pravin";
            Console.WriteLine(Name);
            Name = null;
            Console.WriteLine(Name);



            //////////////  convert int value to null
            int? age = null;

            // Console.WriteLine(age);

            bool? isDelivered = null;

            DateTime? DOB = null;


            //int? a = 10;
            //int b = (int)a;
            //Console.WriteLine($" a : {a}  b : {b}");



            ////////////   to convert nullable type to non-nullable type
            ///

            int? a = null;
            int b = a ?? 0;
            Console.WriteLine($" a : {a}  b : {b}");


            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            string email = "pravinmane9276@gmail.com";
            string emailInUpper = email.ToUpper();
            Console.WriteLine($"email : {email}\nemailInUpper : {emailInUpper}");

            email = null;
            emailInUpper = email?.ToUpper();
            Console.WriteLine($"email : {email}\nemailInUpper : {emailInUpper}");





            Console.ReadLine();
        }
    }
}
