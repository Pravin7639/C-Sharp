using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        { 
            ///////////// if statement
            int i = 10;
            if (i == 10)
            {
                Console.WriteLine($"{i} : TEN");
            }



            ////////// if else statement
            ///
            i = 11;
            if (i == 10)
            {
                Console.WriteLine($"{i} : TEN");
            }
            else
            {
                Console.WriteLine($"{i} : NOT TEN");
            }



            i = 10;
            if (i == 10)
            {
                Console.WriteLine($"{i} : TEN");
            }
            else
            {
                Console.WriteLine($"{i} : NOT TEN");
            }


            ////////////////
            ///if-else if-else

            ///
            i = 200;
            if (i == 10)
            {
                Console.WriteLine($"{i} : TEN");
            }
            else if (i == 20)
            {
                Console.WriteLine($"{i} : TWENTY");
            }
            else if (i == 30)
            {
                Console.WriteLine($"{i} : THIRTY");
            }
            else
            {
                Console.WriteLine($"{i} : NOT TEN,TWENTY OR THIRTY");
            }




            /////////////////////////////
            ///switch statements
            ///

            i = 10;
            switch (i)
            {
                case 10:
                    Console.WriteLine($"{i} : TEN");
                    break;
                case 20:
                    Console.WriteLine($"{i} : TWENTY");
                    break;
                case 30:
                    Console.WriteLine($"{i} : THIRTY");
                    break;
                default:
                    Console.WriteLine($"{i} : NOT TEN,TWENTY OR THIRTY");
                    break;
            }


            Console.ReadLine();
        }
    }
}
