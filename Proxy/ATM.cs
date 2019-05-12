using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ATM : IATM
    {
        int balance;
        public ATM(){
            balance = 500;
        }

        public bool Withdraw(Person p, int amount)
        {
            if (amount > balance)
                return false;
            balance -= amount;
            return true;
        }

        public int GetBalance()
        {
            return balance;
        }
    };
}
