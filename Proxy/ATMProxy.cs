using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ATMProxy
    {
        // real ATM as component
        ATM realThing = new ATM();
        // Proxy checking 
        public bool Withdraw(Person p, int amount)
        {
            if (p.Name() == "Tom" || p.Name() == "Harry" || p.Name() == "Bubba")
                return realThing.Withdraw(p,amount);
            else
                return false;
        }
        public int GetBalance()
        {
            return realThing.GetBalance();
        }
    };
}
