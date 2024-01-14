using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Using Method Overloading

            //Calculator c1 = new Calculator();
            //bool b1 = c1.AreEqual(5, 5);
            //Console.WriteLine(b1); //true

            //b1 = c1.AreEqual(5, 6);
            //Console.WriteLine(b1); //false

            //b1 = c1.AreEqual("ppp", "ppp");
            //Console.WriteLine(b1);  //true

            //b1 = c1.AreEqual("ppp", "PPP");
            //Console.WriteLine(b1); //false

            //b1 = c1.AreEqual(5.5f, 2.5f);
            //Console.WriteLine(b1);// false

            #endregion Using Method Overloading


            #region Using Object Type

            //Calculator c1 = new Calculator();
            //bool b1 = c1.AreEqual(5, 5);
            //Console.WriteLine(b1); //true

            //b1 = c1.AreEqual(5, 6);
            //Console.WriteLine(b1); //false

            //b1 = c1.AreEqual("ppp", "ppp");
            //Console.WriteLine(b1);  //true

            //b1 = c1.AreEqual("ppp", "PPP");
            //Console.WriteLine(b1); //false

            //b1 = c1.AreEqual(5.5f, 2.5f);
            //Console.WriteLine(b1);// false

            #endregion Using Object Type




            #region using Generic

            Calculator c1 = new Calculator();
            bool b1 = c1.AreEqual<int>(5, 5);
            Console.WriteLine(b1);//true

            b1 = c1.AreEqual<string>("a", "b");
            Console.WriteLine(b1);//false

            //   b1 = c1.AreEqual("AA", 10.5f);  // not possible


            b1 = c1.AreEqual<float>(10.5f, 10.5f);
            Console.WriteLine(b1);//true


            c1.Add<int>(10, 11); //21


            c1.Add<string>("a", "b");  //ab


            c1.Add<float>(10.5f, 10.5f);  //21



            /////////////////////////////////////////////////////
            ////////////////////////////////////////////////////
            ///////////////////////////////////////////////////


            Student<int, string> s1 = new Student<int, string>();
            s1.RollNumber = 45;
            s1.Name = "Pravin";
            string r = s1.Details();
            Console.WriteLine(r);



            Student<string, string> s2 = new Student<string, string>();
            s2.RollNumber = "45";
            s2.Name = "PRAVIN";
            string r1 = s2.Details();
            Console.WriteLine(r1);






            #endregion using Generic




            Console.ReadLine();
        }
    }
}
