using System; // to import namespaces
using Cenema;
using Bank;
using ab = Cenema.AbhiRuchi;
using _30_NamspaceDemo.BankModels;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        // System.Console.WriteLine("Hello");   ///fully qualified name....

        //  SilverCustomer sc = new SilverCustomer();
        // sc.Details();

        SavingsCustomer sc1 = new SavingsCustomer();
        sc1.Details();

        //        Customer c = new Customer();///////// ambugity//confusion

        //Cenema.AbhiRuchi.Customer c = new Cenema.AbhiRuchi.Customer();  //fully qualified name
        // Bank.Customer c1 = new Bank.Customer();

        ab.Customer c = new ab.Customer();


        /////////////////////////////////////////////////////////////////////////////////////////
        ///

        Account acc = new Account();
        acc.Details();



        Console.ReadLine();
    }
}

namespace Cenema
{

    namespace AbhiRuchi
    {
        class Customer { }

        class SilverCustomer
        {
            public void Details()
            {
                Console.WriteLine("Silver Customer");
            }
        }
    }
}


namespace Bank
{
    class Customer { }

    class SavingsCustomer
    {
        public void Details()
        {
            Console.WriteLine("Savings Customer");
        }

    }
}
