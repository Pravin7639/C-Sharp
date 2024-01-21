using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("WelcomE To Calculator");
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Please enter a first number : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number : ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an Opertion : ");
            Console.WriteLine("+ : Addition");
            Console.WriteLine("- : Subtraction");
            Console.WriteLine("* : Multiply");
            Console.WriteLine("/ : Devide");
            Console.Write("Enter an Option : ");


            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Addition {num1} + {num2} = {num1 + num2}");
                    break;


                case "-":
                    Console.WriteLine($"Addition {num1} - {num2} = {num1 - num2}");
                    break;


                case "*":
                    Console.WriteLine($"Addition {num1} * {num2} = {num1 * num2}");
                    break;


                case "/":
                    Console.WriteLine($"Addition {num1} / {num2} = {num1 / num2}");
                    break;


                default:
                    Console.WriteLine("INVALID OPTION");
                    break;




            }





            Console.ReadLine();
        }
    }
}
