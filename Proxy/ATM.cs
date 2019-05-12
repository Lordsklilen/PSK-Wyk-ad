using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ATM
    {
        int balance;
        public ATM(){
            balance = 500;
        }

        public bool Withdraw(int amount)
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
