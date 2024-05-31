using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.presenter;

namespace Store
{
    internal class Cart
    {
        private static Cart instance;
        private List<VinylRecord> cartItems;
        public int totalprice;

        private Cart()
        {
            cartItems = new List<VinylRecord>();
        }

        public static Cart Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Cart();
                }
                return instance;
            }
        }

        public List<VinylRecord> GetCartItems()
        {
            return cartItems;
        }

        public void AddToCart(VinylRecord selectedVinylRecord, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                cartItems.Add(selectedVinylRecord);
            }
        }

        public void DeleteFromCart(VinylRecord selectedVinylRecord)
        {
            cartItems.Remove(selectedVinylRecord);
        }

        public int CalculateTotalPrice()
        {
            totalprice = 0;
            foreach (VinylRecord vr in cartItems)
            {
                totalprice += vr.Price;
            }
            return totalprice;
        }
        public int RecalculateCart(int amount)
        {
            totalprice -= amount;
            return totalprice;
        }
        public void SetCartTotal(int total)
        {
            totalprice = total;
        }
        public int GetTotalCart()
        {
            return totalprice;
        }
    }
}

