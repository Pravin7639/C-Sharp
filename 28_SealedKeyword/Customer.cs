using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_SealedKeyword
{
    public class Customer
    {
        public virtual void Print()
        {
            Console.WriteLine("Customer() Method Called");
        }
    }

    public class SilverCustomer : Customer
    {
        public sealed override void Print()
        {
            Console.WriteLine("Silver Customer() Method Called");
        }
    }

    public class GoldCustomer : SilverCustomer
    {
        public new void Print()   // can not override this method because of sealed keyword in base class
        {
            Console.WriteLine("Gold Silver Customer Print()");
        }
    }


}
