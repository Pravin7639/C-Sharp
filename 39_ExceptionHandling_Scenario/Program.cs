using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_ExceptionHandling_Scenario
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = GetData();
            Console.WriteLine(result);



            Console.ReadLine();
        }


        //        public static string GetData()
        //        {
        //// when we call GetData() then only TRY will be OUTPUT
        //            try
        //            {
        //                return "TRY";
        //            }
        //            catch
        //            {
        //                return "CATCH";
        //            }
        //            finally
        //            {
        //                // return "FINALLY";  // return statement is not written in finally block
        //            }

        //        }


        static string GetData()
        {
            string result = "";

            try
            {
                result = "TRY";
                //   return result;
            }
            catch
            {
                result = "Catch";
                // return result;
            }
            finally
            {
                result = "FINALLY";
                //  return result;     
                // return statement can not be written in finally block
                Console.WriteLine("Finally Block Excecuted");
            }
            return result;
        }


    }
}
