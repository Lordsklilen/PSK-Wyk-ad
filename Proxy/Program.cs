using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            ATMProxy pc = new ATMProxy();
            // Initializing Clients
            List<Person> workers = new List<Person>() { new Person(), new Person(), new Person(), new Person()};

            for (int i = 0, amount = 100; i < 4; i++, amount += 100)

                //trying to withdraw money using proxy 
                if (!pc.Withdraw(workers[i], amount))
                    Console.WriteLine("No money for " + workers[i].Name() + '\n');
                else
                    Console.WriteLine(amount + " dollars for " + workers[i].Name() + '\n');
            Console.WriteLine("Remaining balance is " + pc.GetBalance() +'\n');
            Console.ReadKey();
        }
    }
}
