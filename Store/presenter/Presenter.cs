using Store.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Store.presenter
{
    internal class Presenter
    {
        private IView view;
        private Database db;
        DebitCard card = new DebitCard();
        BonusAccount account = new BonusAccount();
        public Presenter(IView view)
        {
            this.view = view;
            db = new Database(this);
            CardPayment cardPayment = new CardPayment(card);
            BonusesPayment bonusesPayment = new BonusesPayment(account);

        }
        public int GetPriceOfVinyl(VinylRecord vinylrecord)
        {
            return vinylrecord.GetPrice();
        }
        public List<VinylRecord> GetVinylRecords()
        {
            return db.GetRecords();
        }
        public string GetDescriptionOfVinylRecord(VinylRecord vinylRecord)
        {
            return vinylRecord.GetDescription();
        }
        public string GetImage(VinylRecord vinylRecord)
        {
            return vinylRecord.GetImage();
        }
        public List<VinylRecord> GetCart()
        {
            return Cart.Instance.GetCartItems(); 
        }
        public void AddToCart(VinylRecord vinylRecord, int amount)
        {
            Cart.Instance.AddToCart(vinylRecord, amount);
        }
        public void DeleteFromCart(VinylRecord vinylRecord)
        {
            Cart.Instance.DeleteFromCart(vinylRecord);
        }
        public int CalculateTotalCart()
        {
            return Cart.Instance.CalculateTotalPrice();
        }
        public int GetTotalCart()
        {
            return Cart.Instance.GetTotalCart();
        }

        public void PayingCard(CardPayment cardPayment, int amount)
        {
            //int totalPrice = GetTotalCart();
            if (cardPayment.ProcessPayment(amount) == true)
            {
                view.ShowMessage("Чек оплачен.");
            }
            else
            {
                view.ShowMessage("Недостаточно средств. \nУдалите товары из корзины или воспользуйтесь бонусами.");
            }
        }
        public void PayingBonuses(BonusesPayment bonusesPayment, int amount)
        {
            if (bonusesPayment.ProcessPayment(amount) == true)
            {
                view.ShowMessage("Бонусы списаны.");
                int updatedPrice = Cart.Instance.RecalculateCart(amount);
                Cart.Instance.SetCartTotal(updatedPrice);
            }
            else
            {
                view.ShowMessage("Введите верное количество бонусов");
            }
        }
        public int GetBalanceFromCard(DebitCard card)
        {
            return card.GetBalance();
        }
        public int GetBalanceFromAccount(BonusAccount account)
        {
            return account.GetBalance();
        }
        public int RecalculateCartAfterPayingBonuses(int amount)
        {
            return Cart.Instance.RecalculateCart(amount);
        }
    }
}
