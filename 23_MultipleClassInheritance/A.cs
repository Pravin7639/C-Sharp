using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_MultipleClassInheritance
{
    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B");
        }
    }

    public class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C");
        }
    }


    //public class D : A,B   // Multiple Inheritance is not possible 
    //{
        
    //}


}
