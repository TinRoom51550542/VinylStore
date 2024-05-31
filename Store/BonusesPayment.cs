using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class BonusesPayment : IPayment
    {
        private BonusAccount account;
        public BonusesPayment(BonusAccount account)
        {
            this.account = account;
        }
        public bool ProcessPayment(int amount)
        {
            if (account.GetBalance() >= amount)
            {
                account.DeductFromBalance(amount);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
