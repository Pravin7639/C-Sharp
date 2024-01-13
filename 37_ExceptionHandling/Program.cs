using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _37_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "Yes";
            do
            {
                try
                {
                    Console.WriteLine("Welcome to Calculator");

                    Console.WriteLine("Please enter Numerator");
                    int num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter Denominator");
                    int den = int.Parse(Console.ReadLine());



                    Divide(num, den);

                }
                //catch (FormatException ex)
                //{
                //    Console.WriteLine($"FormatException : {ex.Message}");
                //    File.WriteAllText(@"Logs\erors.txt", $"{ex.Message} \n");
                //}
                //catch (OverflowException ex)
                //{
                //    Console.WriteLine($"OverflowException : {ex.Message}");
                //    File.WriteAllText(@"Logs\erors.txt", $"{ex.Message} \n");
                //}
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception : {ex.Message}");
                    File.WriteAllText(@"Logs\erors.txt", $"{ex.Message} \n");
                }
                Console.WriteLine("Do you want to continue Y/N");
                s = Console.ReadLine();
            } while (s == "Yes");






            Console.WriteLine("Thank You... Visit Again..");


            Console.ReadLine();
        }

        static void Divide(int num, int den)
        {
            //try
            //{
            try
            {
                int div = num / den;
                Console.WriteLine($"Division : {num} / {den} ={div}");

            }
            catch (DivideByZeroException ex)
            {
                //  Console.WriteLine("Denominator cannot be Zero. Please enter Denominator greater than Zero. ");

                // Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);

                File.WriteAllText(@"Logs\erors.txt", $"{ex.Message} \n");// this is used for saving error information
                //                       path                exception message
                //if path is wrong then this error is handled in outer catch block




            }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Outer catch Block : {ex.Message}");
            //}
            finally
            {

                Console.WriteLine("Division Operation Completed");
            }
        }
    }
}


// error handling means showing meaningfull information to end user
// saving that error information in text to fix issues in future

//  following steps to save error information ... 
// Add new file and in that new file add a TEXT file
// in that text file go to properties an change the settings
// like DO NOT COPY -----TO---- COPY ALWAYS.......


