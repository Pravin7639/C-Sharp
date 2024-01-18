using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _50_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //Early Binding

            //    Customer c = new Customer();
            //    c.PrintA();



            //Late Binding
            //Method--> Class Object--> Class--> NameSpace--> Assembly

            Assembly assembly = Assembly.GetExecutingAssembly();//for getting assembly name///returns assembly type back
            Type customer = assembly.GetType("_50_Reflection.Customer");//for finding type //retuns datatype

            if (customer != null)
            {
                object c = Activator.CreateInstance(customer);  //for finding Method//returns Instance of class

                if (c != null)
                {
                    MethodInfo printA = customer.GetMethod("PrintA");//

                    if (printA != null)
                    {
                        printA.Invoke(c, null);
                    }

                    MethodInfo printC = customer.GetMethod("PrintC");
                    printC.Invoke(c, new object[] { "Pawan", "Mane" });

                }

                MethodInfo printB = customer.GetMethod("PrintB");
                printB.Invoke(c, null);
                printB.Invoke(null, null);
                //null static method needs instance of class
                //static method does not need any instance
                //

                MethodInfo printD = customer.GetMethod("PrintD",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                printD.Invoke(c, null);

            }

            //all methods

            Console.WriteLine("All Methods");
            MemberInfo[] methods = customer.GetMethods();
            for (int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine($"{methods[i]}");
            }

            //all properties
            Console.WriteLine("*** All Properties ***");
            PropertyInfo[] properties = customer.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine($"{properties[i].Name} : " +
                    $"{properties[i].PropertyType}");
            }




            Console.ReadLine();
        }
    }

    public class Customer
    {
        public int CustermerId { get; set; }
        public string Name { get; set; }


        public void PrintA()
        {
            Console.WriteLine("PrintA() Method Called");
        }

        public static void PrintB()
        {
            Console.WriteLine("PrintB() static Method Called");
        }

        public void PrintC(string firstName, string lastName)
        {
            Console.WriteLine($"PrintC() static Method Called : {firstName} {lastName}");
        }

        private void PrintD()
        {
            Console.WriteLine("Private Method : PrintD() Method Called");
        }



    }






}
