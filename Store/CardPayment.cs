using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class CardPayment : IPayment
    {
        private DebitCard card;
        public CardPayment(DebitCard card)
        {
            this.card = card;
        }
        public bool ProcessPayment(int total)
        {
            if (card.GetBalance() >= total)
            {
                card.DeductFromBalance(total);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
