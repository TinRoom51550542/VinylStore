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
        public void ProcessPayment(double amount)
        {
            if (card.GetBalance() >= amount)
            {
            }
            else
            {
            }
        }
    }
}
