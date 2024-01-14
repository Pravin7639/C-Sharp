using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Generics
{
    public class Calculator
    {

        #region Using Method Overloading
        //public bool AreEqual(int a, int b)
        //{
        //    return a.Equals(b);
        //}

        //public bool AreEqual(string a, string b)
        //{
        //    return a.Equals(b);
        //}

        //public bool AreEqual(float a, float b)
        //{
        //    return a.Equals(b);
        //}

        #endregion Using Method Overloading


        #region Using Object Type

        ////problems with object type
        ////1... there is no type safety
        ////2... chances of boxing & unboxing operations



        //public bool AreEqual(object a, object b)
        //{
        //    return a.Equals(b);

        //}



        #endregion Using Object Type



        #region using Generic

        public bool AreEqual<T>(T a, T b)
        {

            return a.Equals(b);

        }

        public void Add<T>(T a, T b)
        {
            //  Console.WriteLine(a + b);// cannot be written because datatype is unknown

            //object n1 = a;
            //object n2 = b;

            //var n1 = a;
            //var n2 = b;


            dynamic n1 = a;
            dynamic n2 = b;

            Console.WriteLine(n1 + n2);
        }



        public TResult MyMethod<Tin, TResult>(Tin a)
        {
            dynamic d = null;
            return d;
        }

        #endregion using Generic





    }

}
