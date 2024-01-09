using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interface
{
    interface IA
    {
        void Print();
        void PrintA();
    }

    interface IB
    {
        void Print();
        void PrintB();
    }

    public class B
    {

    }


    public class A : B, IA, IB
    {
         void IA.Print()
        {
            Console.WriteLine(" IA.Print() Method Called ");
         }

         void IB.Print()
        {
            Console.WriteLine(" IB.Print() Method Called ");
        }
        public void PrintA()
        {
            Console.WriteLine(" PrintA() Method Called ");
        }

        public void PrintB()
        {
            Console.WriteLine(" PrintB() Method Called ");
        }
    }


}
