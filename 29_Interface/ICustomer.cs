using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interface
{
    interface ICustomer1
    {
        //public int rn { get; set; } // we can not create fields inside interface

         void ShowTmings();

    }

    interface ICustomer2 : ICustomer1
    {
        void PrintTicket();
    }

    public class SilverCustomer : ICustomer2
    {
        public void PrintTicket()
        {
            Console.WriteLine("Silver Customer : PrintTicket() Method Called");
        }

        public void ShowTmings()
        {
            Console.WriteLine("Silver Customer : ShowTmings() Method Called");

        }
    }

    public class GoldCustomer : ICustomer2
    {
        public void PrintTicket()
        {
            Console.WriteLine("Gold Customer : PrintTicket() Method Called");
        }

        public void ShowTmings()
        {
            Console.WriteLine("Gold Customer : ShowTmings() Method Called");
        }
    }

}
