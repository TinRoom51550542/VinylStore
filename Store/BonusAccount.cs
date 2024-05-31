using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class BonusAccount
    {
        private int balance = 10000;
        public int GetBalance()
        {
            return balance;
        }
        public void DeductFromBalance(int amount)
        {
            balance -= amount;
        }
    }
}
