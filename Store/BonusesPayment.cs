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
        public void ProcessPayment(double amount)
        {
            if (account.GetBalance() >= amount)
            {
            }
            else
            {
            }
        }
    }
}
