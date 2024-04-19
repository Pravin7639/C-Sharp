using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = string.Empty;
            int sQuant = 0;
           int mQuant = 0;
             int   lQuant = 0;
            int bill = 0;
            do
            {

                Console.WriteLine("Welcome to CCD");

                Console.WriteLine("1-Small Coffee   2-Medium Coffee  3-Large Coffee");

                int size;
                if (int.TryParse(Console.ReadLine(), out size))
                {
                    switch (size)
                    {
                        case 1:
                            Console.WriteLine("You selected Small Coffee");
                            Console.WriteLine("Please Enter Quantity");
                            sQuant = Convert.ToInt32(Console.ReadLine());
                            bill += (sQuant * 10);
                            break;
                        case 2:
                            Console.WriteLine("You selected Medium Coffee");
                            Console.WriteLine("Please Enter Quantity");
                            mQuant = Convert.ToInt32(Console.ReadLine());
                            bill += (mQuant * 20);
                            break;
                        case 3:
                            Console.WriteLine("You selected Large Coffee");
                            Console.WriteLine("Please Enter Quantity");
                            lQuant = Convert.ToInt32(Console.ReadLine());
                            bill += (lQuant * 30);
                            break;

                        default:
                            Console.WriteLine("Invalid Coffee Size");
                            break;




                    }
                    Console.WriteLine($"DO YOU WANT TO CONTINUE");
                    choice = Console.ReadLine().ToUpper();
                }

                else { Console.WriteLine("Invalid coffe"); }
            } while (choice == "Y" || choice == "YES");

            if(sQuant>0)
            {
                Console.WriteLine($"Small Coffe 10*{ sQuant} :-- {10 * sQuant}");
            }


            if (mQuant > 0)
            {
                Console.WriteLine($"Mediem Coffe  20*{mQuant} :--{20 * sQuant}");
            }
            if (lQuant > 0)
            {
                Console.WriteLine($"Large Coffe 30*{lQuant} :-- {30 * lQuant}");
            }
            Console.WriteLine($"BillAmount:-  {bill}");


                Console.WriteLine($"Thank u for visit Again...");
            


           
            
            Console.ReadLine();
        }
    }
}
